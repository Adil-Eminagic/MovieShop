
using AutoMapper;
using FluentValidation;
using MovieShop.Application.Interfaces;
using MovieShop.Core;
using MovieShop.Infrastructure;
using MovieShop.Infrastructure.Interfaces;

namespace MovieShop.Application
{
    public abstract class BaseService<TEntity, TDto, TUpsertDto, TRepository> : IBaseService<int, TDto, TUpsertDto>
        where TEntity : BaseEntity where TDto : BaseDto where TUpsertDto:BaseUpsertDto where TRepository:class,
        IBaseRepository<TEntity, int>
    {
        private const bool ShouldSoftDelete = true;

        protected readonly IMapper Mapper;
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IValidator<TUpsertDto> Validator; // you need to specify type
        protected readonly TRepository CurrentRepository;

        protected BaseService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<TUpsertDto> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
            CurrentRepository = (TRepository)unitOfWork.GetType()
                .GetFields()
                 .First(f => f.FieldType == typeof(TRepository))
                                                       .GetValue(unitOfWork)!; ;
        }

        public async Task<TDto> AddAsync(TUpsertDto dto, CancellationToken cancellationToken = default)
        {
            await ValidateAsync(dto, cancellationToken);
            var entity = Mapper.Map<TEntity>(dto);
            await CurrentRepository.AddAsync(entity, cancellationToken);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
            return Mapper.Map<TDto>(entity);
        }

        public async Task<IEnumerable<TDto>> AddRangeAsync(IEnumerable<TUpsertDto> dtos, CancellationToken cancellationToken = default)
        {
            await ValidateRangeAsync(dtos, cancellationToken);

            var entities = Mapper.Map<IEnumerable<TEntity>>(dtos);
            await CurrentRepository.AddRangeAsync(entities, cancellationToken);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
            return Mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<TDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await CurrentRepository.GetByIdAsync(id, cancellationToken);
            return Mapper.Map<TDto>(entity);
        }

        public async Task RemoveAsync(TDto dto, CancellationToken cancellationToken = default)
        {
            var entity = Mapper.Map<TEntity>(dto);
            CurrentRepository.Remove(entity);
            await UnitOfWork.SaveChangesAsync(cancellationToken);

        }

        public async Task RemoveByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            await CurrentRepository.RemoveByIdAsync(id,ShouldSoftDelete ,cancellationToken);// don'n go in change tracker this method
        }

        public async Task<TDto> UpdateAsync(TUpsertDto dto, CancellationToken cancellationToken = default)
        {
            await ValidateAsync(dto, cancellationToken);

            var entity= Mapper.Map<TEntity>(dto);
            CurrentRepository.Update(entity);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
            return Mapper.Map<TDto>(entity);
        }

        public async Task<IEnumerable<TDto>> UpdateRange(IEnumerable<TUpsertDto> dtos, CancellationToken cancellationToken = default)
        {
            await ValidateRangeAsync(dtos, cancellationToken);

            var enitites = Mapper.Map<IEnumerable<TEntity>>(dtos);
            CurrentRepository.UpdateRange(enitites);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
            return  Mapper.Map<IEnumerable<TDto>>(enitites);
        }

        protected async Task ValidateAsync(TUpsertDto dto, CancellationToken cancellationToken = default)
        {
            var validationResult = await Validator.ValidateAsync(dto, cancellationToken);
            if (validationResult.IsValid == false)
            {
                throw new ValidationException(validationResult.Errors);
            }
        }

        protected async Task ValidateRangeAsync(IEnumerable<TUpsertDto> dtos, CancellationToken cancellationToken = default)
        {
            foreach (var item in dtos)
            {
               await ValidateAsync(item, cancellationToken);
            }
        }
    }
}
