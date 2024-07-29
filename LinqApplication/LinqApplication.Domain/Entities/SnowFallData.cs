namespace LinqApplication.LinqApplication.Domain.Entities
{
    public class SnowFallData
    {
        public int Year { get; set; }
        public List<MonthlySnowFallData> MonthlySnowFallDataItems { get; set; }
    }
}
