namespace LinqApplication.LinqApplication.Library.TakeExercise1
{
    /*
     Implement the TakeSome method, which returns a certain part of the collection, according to this algorithm:

        if there are less than 10 elements in the collection, 
            it returns 3 elements (or all of them, if there are less than 3 elements in the collection)

        if there are 10 or more, but less than 100 elements in the collection,
            it returns 30 elements (or all of them, if there are less than 30 elements in the collection)

        if there are 100 or more elements, 
            it returns all elements
     */
    public class TakeExercise1
    {
        public static IEnumerable<int> TakeSome(IEnumerable<int> numbers)
        {
            return numbers.Count() < 10 ?
                numbers.Take(3) :
                numbers.Count() < 100 ? numbers.Take(30) : numbers;
        }
    }
}
