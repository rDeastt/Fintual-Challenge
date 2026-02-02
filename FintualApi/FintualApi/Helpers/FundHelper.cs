namespace FintualApi.Helpers
{
    public static class FundHelper
    {
        public static string GetFundName(int id) => id switch
        {
            15077 => "Very Conservative Streep",
            188 => "Conservative Clooney",
            187 => "Moderate Pit",
            186 => "Risky Norris",
            _ => "Unknown Fund"
        };
    }
}
