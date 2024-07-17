using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Domain.Enums;


namespace LinqApplication.LinqApplication.Library.All
{
    public class AllExercise2
    {
        public bool AreAllPetsOfTheSameType(IEnumerable<Pet> pets)
        {
            var allPetTypes = Enum.GetValues(typeof(PetType)).Cast<PetType>();

            return allPetTypes.Any(x => pets.All(z => z.PetType == x));
        }
    }
}
