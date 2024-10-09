using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.GenerateCollection
{
    public class GenerateCollectionExcercise2
    {
        public string BuildTree(int levels)
        {
            return string.Join("\n", Enumerable.Range(1, levels)
                         .Select(x => string.Join("", Enumerable.Repeat("*", x))));                             
        }
    }
}
