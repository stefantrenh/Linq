using LinqApplication.LinqApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.FirstAndLast
{
    public class FirstAndLastExcercise2
    {
        public Person GetYoungest(IEnumerable<Person> people)
        {
            return people.OrderBy(x => x.DateOfBirth).LastOrDefault();
        }
    }
}
