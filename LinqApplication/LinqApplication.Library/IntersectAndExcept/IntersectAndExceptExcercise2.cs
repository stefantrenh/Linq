using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.IntersectAndExcept
{
    public class IntersectAndExceptExcercise2
    {
        public IEnumerable<int> GetExclusiveNumbers(IEnumerable<int> numbers1, IEnumerable<int> numbers2)
        {
            return numbers1.Except(numbers2)
                           .Concat(numbers2.Except(numbers1))
                           .OrderBy(x => x);
        }
    }
}
