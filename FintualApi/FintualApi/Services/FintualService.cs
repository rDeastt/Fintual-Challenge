using FintualApi.Models.DTOs;
using FintualApi.Models.Externals;
using FintualApi.Services.Interfaces;

namespace FintualApi.Services
{
    public class FintualService : IFintualService
    {
        private readonly HttpClient _http;

        public FintualService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<FintualDay>> GetFundDays(
            int fundId,
            DateTime from,
            DateTime to)
        {
            var url =
                $"https://fintual.cl/api/real_assets/{fundId}/days" +
                $"?from_date={from:yyyy-MM-dd}&to_date={to:yyyy-MM-dd}";

            var response =
                await _http.GetFromJsonAsync<FintualResponse>(url);

            return response?.Data ?? new List<FintualDay>();
        }

        public List<MonthlyVariationDto> CalculateMonthlyVariation(
            List<FintualDay> days,
            int fundId,
            string fundName)
        {
            return days
                .GroupBy(d => new
                {
                    d.Attributes.Date.Year,
                    d.Attributes.Date.Month
                })
                .Select(group =>
                {
                    var ordered = group
                        .OrderBy(d => d.Attributes.Date)
                        .ToList();

                    var startPrice = ordered.First().Attributes.Price;
                    var endPrice = ordered.Last().Attributes.Price;

                    return new MonthlyVariationDto
                    {
                        FundId = fundId,
                        FundName = fundName,
                        Month = $"{group.Key.Year}-{group.Key.Month:D2}",
                        StartPrice = startPrice,
                        EndPrice = endPrice,
                        Variation = ((endPrice - startPrice) / startPrice) * 100
                    };
                })
                .OrderBy(r => r.Month)
                .ToList();
        }
    }
}
