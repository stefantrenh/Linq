using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.CollectionTypeChange
{
    /*
     Implement the ParseToNumbersAndStoreInDictionary method, 
        which given a collection of words will return a dictionary where each of the words is the key, 
        and the value is either an integer parsed from this string or null if parsing was unsuccessful.

        For example, for input collection {"aaa", "1", "3", "bbb", "bbb"} the result shall be:        
        ["aaa"] = null,      
        ["1"] = 1,        
        ["3"] = 3,      
        ["bbb"] = null    
    
        Please note that the string "bbb" occurred twice in the input collection, but it occurs only once in the dictionary (the dictionary keys must be unique).
     */
    public class CollectionTypeChangeExcercise1
    {
        public static Dictionary<string, int?> ParseToNumbersAndStoreInDictionary(IEnumerable<string> words)
        {
            return words.Distinct()
                        .ToDictionary(word => word, 
                        word => {
                            int parse;

                            return int.TryParse(word, out parse) ? parse : (int?)null;
                        });
        }
    }
}
