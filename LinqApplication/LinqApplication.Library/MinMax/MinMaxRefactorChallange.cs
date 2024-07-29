using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Domain.Enums;

namespace LinqApplication.LinqApplication.Library.MinMax
{
    public class MinMaxRefactorChallange
    {
        //TODO implement this method
        public static int CountOfDogsOfTheOwnerWithMostDogs_Refactored(IEnumerable<Person> owners)
        {
            return owners.Max(x => x.Pets.Count(z => z.PetType == PetType.Dog));
        }

        //do not modify this method
        public static int CountOfDogsOfTheOwnerWithMostDogs(IEnumerable<Person> owners)
        {
            var maxDogCount = 0;
            foreach (var owner in owners)
            {
                var dogsCount = 0;
                foreach (var pet in owner.Pets)
                {
                    if (pet.PetType == PetType.Dog)
                    {
                        dogsCount++;
                    }
                }
                if (dogsCount > maxDogCount)
                {
                    maxDogCount = dogsCount;
                }
            }
            return maxDogCount;
        }
    }
}
