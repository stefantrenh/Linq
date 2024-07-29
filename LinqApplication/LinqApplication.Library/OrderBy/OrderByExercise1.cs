namespace LinqApplication.LinqApplication.Library.OrderBy
{
    public class OrderByExercise1
    {
        /*
         Using LINQ, implement the OrderFromLongestToShortest method, which takes a collection of strings, and returns those strings ordered from longest to shortest.
         For example, for {"bb", "a", "ccc"} the result should be {"ccc", "bb", "a"}
         */
        public IEnumerable<string> OrderFromLongestToShortest(IEnumerable<string> words)
        {
            return words.OrderByDescending(x => x.Length);
        }
    }
}
