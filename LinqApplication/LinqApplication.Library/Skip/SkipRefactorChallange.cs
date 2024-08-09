using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Skip
{
    public class SkipRefactorChallange
    {
        //TODO implement this method
        public static IEnumerable<int> GetAllAfterFirstDividableBy100_Refactored(IEnumerable<int> numbers)
        {
            return numbers.SkipWhile(x => x % 100 != 0);
        }

        public static IEnumerable<int> GetAllAfterFirstDividableBy100(IEnumerable<int> numbers)
        {
            var result = new List<int>();
            bool startAdding = false;
            foreach (var number in numbers)
            {
                if (!startAdding && number % 100 == 0)
                {
                    startAdding = true;
                }
                if (startAdding)
                {
                    result.Add(number);
                }
            }
            return result;
        }
    }
}
