using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Count
{
    public class CountExercise1
    {
        public int CountAllLongWords(IEnumerable<string> words)
        {
            return words.Count(x => x.Length > 10);
        }
    }
}
