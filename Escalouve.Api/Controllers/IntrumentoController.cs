using Escalouve.Application.Dtos;
using Escalouve.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Escalouve.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntrumentoController : ControllerBase
    {
        private readonly IInstrumentoService _instrumentoService;

        public IntrumentoController(IInstrumentoService instrumentoService)
        {
            _instrumentoService = instrumentoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _instrumentoService.GetAllAsync();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _instrumentoService.GetByIdAsync(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] InstrumentoDto instrumentoDto)
        {
            var result = await _instrumentoService.CreateAsync(instrumentoDto);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] InstrumentoDto instrumentoDto)
        {
            var result = await _instrumentoService.UpdateAsync(instrumentoDto);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _instrumentoService.DeleteAsync(id);

            return Ok();
        }
    }
}
