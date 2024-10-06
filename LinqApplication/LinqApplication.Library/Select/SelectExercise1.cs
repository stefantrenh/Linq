namespace LinqApplication.LinqApplication.Library.Select
{
    /*
     Imagine you work on an application that retrieves data from scanned paper documents. 
        Let's say you only want to retrieve numbers from some particular documents, unfortunately, they contain other data, like dates, strings, etc.

        Implement the GetNumbers method, which given a collection of objects of different types, will return a collection of integers. 
        Please note that if an object in the input collection is a string, it should be parsed to int if possible.

        For example, for input collection {"1", 3, "abc", new DateTime(2020,1,2), true, "10"} the result shall be {1,3,10}.

        The result collection shall be ordered from least to greatest.
     */
    public class SelectExercise1
    {
        public static IEnumerable<int> GetNumbers(IEnumerable<object> objects)
        {
            var ints = objects.OfType<int>().ToList();
            var strings = objects.OfType<string>().Where(x => x.All(c => Char.IsDigit(c)))
                                 .Select(z => int.Parse(z))
                                 .ToList();

            var numberlist = ints.Concat(strings)
                                 .OrderBy(n => n)
                                 .ToList();

            return numberlist;
        }
    }
}
