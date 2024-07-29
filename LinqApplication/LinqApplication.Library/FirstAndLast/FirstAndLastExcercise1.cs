namespace LinqApplication.LinqApplication.Library.FirstAndLast
{
    /*
     Implement the FindFirstNameInTheCollection method, which takes a collection of strings as a parameter, 
    and as a result, it returns the first valid name from this collection.
    A string is a valid name if:
    it consists of at least two letters
    it starts with an upper case character
    all other characters in this word are lower case
    If there are no valid names in this collection, the result should be null.
     */
    public class FirstAndLastExcercise1
    {
        public string FindFirstNameInTheCollection(IEnumerable<string> words)
        {
            return words.FirstOrDefault(
                         x => x.Length > 1 &&
                         char.IsUpper(x.First()) &&
                         x.Count(z => char.IsUpper(z)) == 1);      
        }
    }
}
