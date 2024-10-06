
namespace LinqApplication.LinqApplication.Domain.Entities
{
    public class Person
    {
        public string Name { get; }
        public IEnumerable<Friend>? Friends { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IEnumerable<Pet>? Pets { get; set; }

        public Person(string name, IEnumerable<Friend> friends, IEnumerable<Pet> pets)
        {
            Name = name;
            Friends = friends;
            Pets = pets;
        }
    }
}
