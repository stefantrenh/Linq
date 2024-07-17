using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.All
{
    public class AllExercise1
    {
        public bool AreAllNumbersDivisibleBy10(int[] numbers)
        {
            return numbers.All(n => n % 10 == 0);
        }
    }
}
