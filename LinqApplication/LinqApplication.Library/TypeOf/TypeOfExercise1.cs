namespace LinqApplication.LinqApplication.Library.TypeOf
{
    public class TypeOfExercise1
    {
        /*
         Implement the GetTheFirstInteger method, 
            which given a collection of objects, 
            will return the first integer from this collection. 
            If no integer is present, it shall return null.
         */
        public int? GetTheFirstInteger(IEnumerable<object> objects)
        {
            return objects.OfType<int?>()
                           .FirstOrDefault();
        }
    }
}
