using LinqApplication.LinqApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.TakeExercise1
{
    public class TakeExcercise2
    {
        public IEnumerable<Pet> GetGivenPercentOfHeaviestPets(IEnumerable<Pet> pets, int percent)
        {
            return pets.OrderByDescending(pet => pet.Weight)
                       .Take(pets.Count() * percent);
        }
    }
}
