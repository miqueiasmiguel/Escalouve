using Escalouve.Application.Dtos;
using Escalouve.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Escalouve.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegranteController : ControllerBase
    {
        private readonly IIntegranteService _integranteService;

        public IntegranteController(IIntegranteService integranteService)
        {
            _integranteService = integranteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _integranteService.GetAllAsync();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _integranteService.GetByIdAsync(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] IntegranteDto integranteDto)
        {
            var result = await _integranteService.CreateAsync(integranteDto);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] IntegranteDto integranteDto)
        {
            var result = await _integranteService.UpdateAsync(integranteDto);

            return Ok(result);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> AlternarStatusAsync(int id)
        {
            await _integranteService.AlternarStatusAsync(id);

            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _integranteService.DeleteAsync(id);

            return Ok();
        }
    }
}
