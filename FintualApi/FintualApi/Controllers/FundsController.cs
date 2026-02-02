using FintualApi.Helpers;
using FintualApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FintualApi.Controllers
{
    [ApiController]
    [Route("api/funds")]
    public class FundsController : ControllerBase
    {
        private readonly IFintualService _service;

        public FundsController(IFintualService service)
        {
            _service = service;
        }

        [HttpGet("monthly-variation")]
        public async Task<IActionResult> GetMonthlyVariation(
            [FromQuery] int fundId,
            [FromQuery] DateTime from,
            [FromQuery] DateTime to)
        {
            if (from > to)
                return BadRequest("La fecha 'from' no puede ser mayor que 'to'.");

            var days = await _service.GetFundDays(fundId, from, to);

            if (!days.Any())
                return NotFound("No hay datos para el rango seleccionado.");

            var result = _service.CalculateMonthlyVariation(
                days,
                fundId,
                FundHelper.GetFundName(fundId));

            return Ok(result);
        }
    }
}