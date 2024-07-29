using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Domain.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public IEnumerable<int> Marks { get; set; }
    }
}
