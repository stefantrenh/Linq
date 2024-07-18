

namespace LinqApplication.LinqApplication.Library.Any
{
    public class AnyExercise1
    {
        /*
         Using LINQ, implement the IsAnyNumberNegative method that checks if any number in the collection is smaller than 0.
         */
        public bool IsAnyNumberNegative(IEnumerable<int> numbers)
        {
            return numbers.Any(x => x < 0);
        }
    }
}
