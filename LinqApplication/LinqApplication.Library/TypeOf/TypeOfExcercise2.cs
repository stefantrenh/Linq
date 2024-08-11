namespace LinqApplication.LinqApplication.Library.TypeOf
{
    public class TypeOfExcercise2
    {
        /*
         Implement the AreAllStringsUpperCase method which will check if all strings present in the objects collection are upper case. 
         If there is no string at all in this collection, the result should be true.
         */
        public bool AreAllStringsUpperCase(IEnumerable<object> objects)
        {
            return objects.OfType<string>()
                          .All(x => x == x.ToUpper());
        }
    }
}
