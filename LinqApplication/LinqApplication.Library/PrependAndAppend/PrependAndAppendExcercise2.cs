namespace LinqApplication.LinqApplication.Library.PrependAndAppend
{
    public class PrependAndAppendExcercise2
    {
        public static IEnumerable<int> RemoveDuplicatesFromStartAndEnd(IEnumerable<int> numbers)
        {
            if (numbers.Count() < 2)
            {
                return numbers;
            }

            var firstNumb = numbers.First();
            var lastNumb = numbers.Last();

            return numbers.Where(number => number != firstNumb)
                          .Prepend(firstNumb)
                          .Where(number => number != lastNumb)
                          .Append(lastNumb);
        }
    }
}
