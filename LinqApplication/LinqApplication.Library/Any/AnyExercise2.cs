using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Domain.Enums;

namespace LinqApplication.LinqApplication.Library.Any
{
    public class AnyExercise2
    {
        /*
         Using LINQ, implement the AreThereAnyBigCats method, which will check if in the collection of Pets there is a cat that weighs over 2 kilos.
         */

        public bool AreThereAnyBigCats(IEnumerable<Pet> pets)
        {
            return pets.Any(x => x.Weight > 2 && x.PetType == PetType.Cat);
        }
    }
}
