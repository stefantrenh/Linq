﻿
namespace LinqApplication.LinqApplication.Library.MinMax
{
    public class MinMaxExcercise1
    {
        /*
         Using LINQ, implement the LengthOfTheShortestWord method,
        which will find the length of the shortest word in the words collection. The returned type should be nullable int. If the collection is empty, the result should be null.
        
        For example:
        for words {"aaa", "bb", "c", "dddd"} the result should be 1, because word "c" is the shortest word, and it has a length of 1
        for an empty collection of words, the result shall be null
         */

        public int? LengthOfTheShortestWord(IEnumerable<string> words)
        {
            return words.Min(x => x?.Length);
        }
    }
}
