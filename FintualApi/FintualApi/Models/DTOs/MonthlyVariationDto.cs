namespace FintualApi.Models.DTOs
{
    public class MonthlyVariationDto
    {
        public int FundId { get; set; }
        public string FundName { get; set; } = string.Empty;
        public string Month { get; set; } = string.Empty;
        public decimal StartPrice { get; set; }
        public decimal EndPrice { get; set; }
        public decimal Variation { get; set; }
    }
}
