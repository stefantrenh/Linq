namespace LinqApplication.LinqApplication.Library.SelectMany
{
    public class SelectManyExcercise1
    {
        public IEnumerable<string> BuildCartesianProduct(HashSet<int> numbers)
        {
            return numbers.SelectMany(number1 => numbers,(number1, number2) => $"{number1},{number2}");
        }
    }
}
