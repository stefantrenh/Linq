using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Domain.Enums;

namespace LinqApplication.LinqApplication.Library.Any
{
    public class AnyExercise2
    {
        public bool AreThereAnyBigCats(IEnumerable<Pet> pets)
        {
            return pets.Any(x => x.Weight > 2 && x.PetType == PetType.Cat);
        }
    }
}
