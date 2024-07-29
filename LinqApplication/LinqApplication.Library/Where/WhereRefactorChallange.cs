using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Domain.Enums;

namespace LinqApplication.LinqApplication.Library.Where
{
    public class WhereRefactorChallange
    {
        //TODO implement this method
        public IEnumerable<Person> GetMultipleFishOwners_Refactored(IEnumerable<Person> people)
        {
            return people.Where(person => person.Pets.Count(pet => pet.PetType == PetType.Fish) > 1);
        }

        //don't modify this method
        public IEnumerable<Person> GetMultipleFishOwners(IEnumerable<Person> people)
        {
            var result = new List<Person>();
            foreach (var person in people)
            {
                var count = 0;
                foreach (var pet in person.Pets)
                {
                    if (pet.PetType == PetType.Fish)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    result.Add(person);
                }
            }
            return result;
        }
    }
}
