using LinqApplication.LinqApplication.Domain.Entities;

namespace LinqApplication.LinqApplication.Library.FirstAndLast
{
    public class FirstAndLastRefactoringChallange
    {
        //TODO implement this method
        public static Person FindOwnerOf_Refactored(Pet pet, IEnumerable<Person> people)
        {
            return people.FirstOrDefault(x => x.Pets.Contains(pet));
        }

        //do not modify this method
        public static Person FindOwnerOf(Pet pet, IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                foreach (var personsPet in person.Pets)
                {
                    if (personsPet == pet)
                    {
                        return person;
                    }
                }
            }
            return null;
        }
    }
}
