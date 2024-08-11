namespace LinqApplication.LinqApplication.Library.Distinct
{
    public class DistinctExcercise2
    {
        /*
         Implement the GetCollectionWithMostDuplicates method, 
         which given a collection of collections will return the collection with the most duplicates in it. 
         If a couple of collections have the same count of duplicates, the shortest should be returned. 
         If the collections parameter is empty, the result shall be null.

            Let's consider the following collections:

            {1,2,3,4} - it has 0 duplicates
            {1,2,3,3,4,4,4} - it has 3 duplicates: one 3 is a duplicate, and two 4s are duplicates
            {1,2,3,3,4,4,4,5,6,7} - it has 3 duplicates: one 3 is a duplicate, and two 4s are duplicates
            The result shall be the second collection, because it has the most duplicates, and it is the shortest of two collections with 3 duplicates
         */

        public IEnumerable<T> GetCollectionWithMostDuplicates<T>(IEnumerable<IEnumerable<T>> collections)
        {
            return collections.OrderBy(x => x.Count() - x.Distinct().Count())
                              .ThenByDescending(x => x.Count())
                              .LastOrDefault();
        }
    }
}
