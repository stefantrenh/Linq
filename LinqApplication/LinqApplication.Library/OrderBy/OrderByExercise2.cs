using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.OrderBy
{
    /*
     Using LINQ, implement the FirstEvenThenOddDescending method, which orders numbers like this:
     first, the even numbers
     then, the odd numbers
    Then the numbers should be ordered descending. 
    For example, for numbers {1,2,3,4,5,6,7} the result should be: {6,4,2,7,5,3,1}.
     */

    public class OrderByExercise2
    {
        public IEnumerable<int> FirstEvenThenOddDescending(IEnumerable<int> numbers)
        {
            return numbers.OrderByDescending(x => x % 2 != 0)
                   .ThenByDescending(y => y);
        }
    }
}
