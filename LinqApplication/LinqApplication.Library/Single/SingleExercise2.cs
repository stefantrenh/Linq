namespace LinqApplication.LinqApplication.Library.Single
{
    /*
     Implement the GetSingleElementCollection method, 
     which given a nested collection of integers will return the only collection which contains only a single element.

    For example, for numberCollections parameter like this:
        numberCollections[0] = {1,2,3}
        numberCollections[1] = {4}
        numberCollections[2] = {5,6}

    ...the result shall be numberCollections[1], because it is the only single-element collection in the input parameter
    If there is no single-element list present, or there is more than one list like that, an InvalidOperationException should be thrown.

    For example, for numberCollections parameter like this:
        numberCollections[0] = {1,2,3}
        numberCollections[1] = {5,6}
    ...InvalidOperationException should be thrown, because there is no single-element collection here.

    For example, for numberCollections parameter like this:
        numberCollections[0] = {1,2,3}
        numberCollections[1] = {4}
        numberCollections[2] = {5,6}
        numberCollections[3] = {7}
    ...InvalidOperationException should be thrown, because there are two single-element collections here.
     */
    public class SingleExercise2
    {
        public IEnumerable<int> GetSingleElementCollection(IEnumerable<IEnumerable<int>> numberCollections)
        {
            return numberCollections.Single(x => x.Count() == 1);
        }
    }
}
