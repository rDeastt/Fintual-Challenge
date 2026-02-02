using FintualApi.Models.Externals;
using FintualApi.Models.DTOs;

namespace FintualApi.Services.Interfaces
{
    public interface IFintualService
    {
        Task<List<FintualDay>> GetFundDays(
            int fundId,
            DateTime from,
            DateTime to);

        List<MonthlyVariationDto> CalculateMonthlyVariation(
            List<FintualDay> days,
            int fundId,
            string fundName);
    }
}
