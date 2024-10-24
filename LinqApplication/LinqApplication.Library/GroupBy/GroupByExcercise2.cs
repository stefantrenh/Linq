using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Domain.Enums;

namespace LinqApplication.LinqApplication.Library.GroupBy
{
    public class GroupByExcercise2
    {
        public PetType? FindTheHeaviestPetType(IEnumerable<Pet> pets)
        {
            return pets.Count() > 0 ? pets.GroupBy(pet => pet.PetType)
                                          .OrderByDescending(pet => pet.Average(x => x.Weight))
                                          .First()
                                          .Key: (PetType?)null;
        }
    }
}
