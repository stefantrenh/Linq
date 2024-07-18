using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.All
{

    /*
     Use LINQ to implement the AreAllNumbersDivisibleBy10 method, 
    which checks if all numbers in the collection are divisible by 10.
     */
    public class AllExercise1
    {
        public bool AreAllNumbersDivisibleBy10(int[] numbers)
        {
            return numbers.All(n => n % 10 == 0);
        }
    }
}
