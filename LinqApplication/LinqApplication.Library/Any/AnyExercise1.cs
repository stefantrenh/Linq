

namespace LinqApplication.LinqApplication.Library.Any
{
    public class AnyExercise1
    {
        public bool IsAnyNumberNegative(IEnumerable<int> numbers)
        {
            return numbers.Any(x => x < 0);
        }
    }
}
