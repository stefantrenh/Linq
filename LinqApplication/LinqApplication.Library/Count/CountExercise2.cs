using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Count
{
    public class CountExercise2
    {
        public bool AreThereFewerOddThanEvenNumbers(IEnumerable<int> numbers)
        {
            return numbers.Count(n => n % 2 == 0) > numbers.Count(n => n % 2 != 0);
        }
    }
}
