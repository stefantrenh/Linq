using LinqApplication.LinqApplication.Domain.Entities;

namespace LinqApplication.LinqApplication.Library.ElementAt
{
    /*
     Using LINQ, implement the FormatPetDataAtIndex method, 
     which takes a collection of pets and an index, and does the following:
     if the index is valid and the pet at this index is not null, 
     the result should be "Pet name: NAME" where NAME is the name of this pet
     otherwise, the result should be "Pet data is missing for index INDEX" where INDEX is the index we tried to access
     */

    /*
     Note that i did not create the same object type in the test such as Pet Class. I used
     the Pet entity which contains more propertys.

    Correct Answer in Test

        var pet = pets.ElementAtOrDefault(index);
            return pet != null ? $"Pet name: {pet.Name}" : $"Pet data is missing for index {index}";
     */
    public class ElementAtExcercise2
    {
        public string FormatPetDataAtIndex(IEnumerable<Pet> pets, int index)
        {
            var pet = pets.ElementAtOrDefault(index);
            return pet != null && pet.Name != null ? $"Pet name: {pet.Name}" : $"Pet data is missing for index {index}";
        }
    }
}
