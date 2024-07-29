﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Where
{
    /*
     Implement the GetProperlyIndexedWords method, which takes a collection of words as a parameter, and returns only those words, that start with a proper index. A proper index shall say at which place the word in the collection is. So the first word shall start with "1.", the third shall start with "3." etc.

        For example:
            for words {"1.AAA", "2.BBB", "invalidWord", "4.DDD"} the result should be {"1.AAA", "2.BBB", "4.DDD"}
            for words {"1.AAA", "2.BBB",  "4.DDD"} the result should be {"1.AAA", "2.BBB"}  because "4.DDD" has an invalid index (it is the third word in the collection, so it's index should be 3)
            for words {"0.AAA", "2.BBB", "invalidWord", "5.DDD"} the result should be {"2.BBB"}, because "0.AAA" is the first word, so it shall start with "1", and "5.DDD" is the fourth word, so it shall start with "4". "invalidWord" is invalid, because it doesn't start with an index at all.
     */
    public class WhereExcercise2
    {
        public IEnumerable<string> GetProperlyIndexedWords(IEnumerable<string> words)
        {
            return words.Where(
                (word, index) => word.StartsWith($"{index + 1}"));
        }
    }

}
