namespace LinqApplication.LinqApplication.Library.Distinct
{
    /*
     Implement the AreAllUnique method, which will check if all elements of a collection are unique.
    For example:
        for numbers 1,2,3,4 the result shall be true because no number is duplicated
        for strings AAA, BBB, BBB, CCC the result shall be false because BBB is duplicated
    */
    public class DistinctExcercise1
    {
        public bool AreAllUnique<T>(IEnumerable<T> collection)
        {
            return collection.Distinct().Count() == collection.Count();
        }
    }
}
