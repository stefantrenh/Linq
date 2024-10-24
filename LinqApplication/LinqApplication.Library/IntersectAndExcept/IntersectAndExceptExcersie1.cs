namespace LinqApplication.LinqApplication.Library.IntersectAndExcept
{
    public class IntersectAndExceptExcersie1
    {
        public int CountCommonWords(IEnumerable<string> words1, IEnumerable<string> words2)
        {
            return words1.Intersect(words2, StringComparer.OrdinalIgnoreCase)
                         .Count();
        }
    }
}
