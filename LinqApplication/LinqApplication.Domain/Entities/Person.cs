
namespace LinqApplication.LinqApplication.Domain.Entities
{
    public class Person
    {
        public string Name { get; }
        public IEnumerable<Friend> Friends { get; set; }

        public Person(string name, IEnumerable<Friend> friends)
        {
            Name = name;
            Friends = friends;
        }
    }
}
