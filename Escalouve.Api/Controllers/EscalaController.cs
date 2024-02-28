using Escalouve.Application.Dtos;
using Escalouve.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Escalouve.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscalaController : ControllerBase
    {
        private readonly IEscalaService _escalaService;

        public EscalaController(IEscalaService escalaService)
        {
            _escalaService = escalaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _escalaService.GetAllAsync();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _escalaService.GetByIdAsync(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] EscalaDto escalaDto)
        {
            var result = await _escalaService.CreateAsync(escalaDto);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] EscalaDto escalaDto)
        {
            var result = await _escalaService.UpdateAsync(escalaDto);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _escalaService.DeleteAsync(id);

            return Ok();
        }
    }
}
