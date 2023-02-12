
namespace MovieShop.Application.Interfaces
{
    public interface IBaseService<TPrimaryKey, TDto, TUpsertDto> where TDto : class  where TUpsertDto : class
    {
        Task<TDto?> GetByIdAsync(TPrimaryKey id, CancellationToken cancellationToken=default);

        Task<TDto> AddAsync(TUpsertDto dto, CancellationToken cancellationToken = default);
        Task<IEnumerable<TDto>> AddRangeAsync(IEnumerable<TUpsertDto> dtos, CancellationToken cancellationToken = default);

        Task<TDto> UpdateAsync(TUpsertDto dto, CancellationToken cancellationToken = default);
        Task<IEnumerable<TDto>> UpdateRange(IEnumerable<TUpsertDto> dtos, CancellationToken cancellationToken = default);

        Task RemoveAsync(TDto dto, CancellationToken cancellationToken = default);
        Task RemoveByIdAsync(TPrimaryKey id, CancellationToken cancellationToken = default);
    }
}
