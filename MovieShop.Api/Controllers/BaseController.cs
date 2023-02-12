using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieShop.Application;
using MovieShop.Application.Interfaces;
using MovieShop.Core;

namespace MovieShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TDto, TUpsertDto, TService> : ControllerBase
        where TService : IBaseService<int,TDto , TUpsertDto>
        where TUpsertDto : BaseUpsertDto
        where TDto: BaseDto
    {
        protected readonly TService Service;

        public BaseController(TService service)
        {
            Service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]int id, CancellationToken cancellationToken=default) 
        {
            try
            {
                var dto = await Service.GetByIdAsync(id, cancellationToken);
                return Ok(dto);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(TUpsertDto dto, CancellationToken cancellationToken = default)
        {
            try
            {
                var obj= await Service.AddAsync(dto, cancellationToken);
                return Ok(obj);
            }
            catch (Exception e)
            {

                return BadRequest($"{e.Message}");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(TUpsertDto dto, CancellationToken cancellationToken = default)
        {
            try
            {
                var obj = await Service.UpdateAsync(dto, cancellationToken);
                return Ok(obj);
            }
            catch (Exception w)
            {

                return BadRequest(w.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int id , CancellationToken cancellationToken = default)
        {
            try
            {
                await Service.RemoveByIdAsync(id, cancellationToken);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
