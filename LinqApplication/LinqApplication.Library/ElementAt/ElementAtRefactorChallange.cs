using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.ElementAt
{
    public class ElementAtRefactorChallange
    {
        //TODO implement this method
        public bool IsEmptyAtIndex_Refactored(IEnumerable<string> words, int index)
        {
            return string.IsNullOrEmpty(words.ElementAtOrDefault(index));
        }

        //do not modify this method
        public static bool IsEmptyAtIndex(IEnumerable<string> words, int index)
        {
            var array = words.ToArray();
            if (index < 0 || index >= array.Length)
            {
                return true;
            }
            if (string.IsNullOrEmpty(array[index]))
            {
                return true;
            }
            return false;
        }
    }
}
