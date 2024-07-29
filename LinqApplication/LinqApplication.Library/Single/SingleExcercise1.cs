namespace LinqApplication.LinqApplication.Library.Single
{

    /*
     Implement the GetTheOnlyUpperCaseWord method, which given a collection of strings:
        will return the only upper case string, if only one is present
        will return null if no upper case string is present
        will throw an InvalidOperationException if two or more upper case strings are present.

    For example:
        for words {"aaa", "BBB", "CcC"} the result will be "BBB"
        for words {"aaa", "bbB", "CcC"} the result will be null
        for words {"aaa", "BBB", "CcC", "DDD"} InvalidOperationException will be thrown
     */
    public class SingleExcercise1
    {
        public string GetTheOnlyUpperCaseWord(IEnumerable<string> words)
        {
           return words.SingleOrDefault(word => word == word.ToUpper());
        }
    }
}
