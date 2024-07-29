using LinqApplication.LinqApplication.Domain.Entities;

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
