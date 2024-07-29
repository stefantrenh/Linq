namespace LinqApplication.LinqApplication.Library.Average
{
    public class AverageRefactorChallange
    {
        //TODO implement this method
        public float CalculateAverageHeight_Refactored(List<float?> heights, float defaultIfNull)
        {
            return heights == null || !heights.Any() ? 0 : heights.Average(x => x ?? defaultIfNull);
        }

        //do not modify this method
        public float CalculateAverageHeight(List<float?> heights, float defaultIfNull)
        {
            if (heights == null || heights.Count == 0)
            {
                return 0;
            }
            var sum = 0f;
            foreach (var height in heights)
            {
                if (height == null)
                {
                    sum += defaultIfNull;
                }
                else
                {
                    sum += height.Value;
                }
            }
            return sum / heights.Count;
        }
    }
}
