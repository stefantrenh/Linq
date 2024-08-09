using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Skip
{
    /*
     Using LINQ, implement the GetWordsBetweenStartAndEnd method which given a list of words, will return all words that lay between words "START" and "END".

    For example:
        for words {"aaa", "START", "bbb", "ccc", "END", "ddd"} the result shall be { "bbb", "ccc"}
        for words {"aaa", "START", "END", "ddd"} the result shall be empty

    The result shall also be empty if any of those conditions are met:
        "START" or "END" words are not present in this collection, or they occur more than once
        "START" is placed after "END"

    That means, the result shall be empty for all of those collections:
        {"aaa", "START", "bbb", "ccc",  "ddd"} - because END is not present
        {"aaa",  "bbb", "ccc",  "ddd", "END"} - because START is not present
        {"aaa",  "START", "ccc",  "START", "END"} - because START occurs twice
        {"aaa",  "START", "ccc",  "END ", "END"} - because END occurs twice
        {"aaa",  "END ", "ccc",  "START"} - because START is placed after END
     */
    public class SkipExercise2
    {
        public IEnumerable<string> GetWordsBetweenStartAndEnd(List<string> words)
        {
            const string start = "START";
            const string end = "END";

            var validList = words.Count(x => x == start) == 1 && 
                words.Count(x => x == end) == 1 &&
                words.IndexOf(start) < words.IndexOf(end);

            return validList ?
                words.SkipWhile(word => word != start)
                     .Skip(1)
                     .TakeWhile(word => word != end)
                : Enumerable.Empty<string>();
        }
    }
}
