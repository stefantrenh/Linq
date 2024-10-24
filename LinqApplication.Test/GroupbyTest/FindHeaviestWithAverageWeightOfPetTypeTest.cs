using AutoFixture;
using FluentAssertions;
using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Domain.Enums;
using LinqApplication.LinqApplication.Library.GroupBy;

namespace LinqApplication.Test.GroupbyTest
{
    public class FindHeaviestWithAverageWeightOfPetTypeTest
    {
        protected IEnumerable<Pet> ienumerablePets;
        protected Fixture fixture;
        protected GroupByExcercise2 excercise2;

        public FindHeaviestWithAverageWeightOfPetTypeTest()
        {
            fixture = new Fixture();
            ienumerablePets = CreatePetList();
            excercise2 = new GroupByExcercise2();
        }

        private IEnumerable<Pet> CreatePetList()
        {
            var cats = fixture.CreateMany<Pet>(2)
                              .Select(x => CreatePet(10,PetType.Cat));

            var dogs = fixture.CreateMany<Pet>(2)
                              .Select(x => CreatePet(20, PetType.Dog));

            var fish = fixture.CreateMany<Pet>(2)
                              .Select(x => CreatePet(1, PetType.Fish));

            var petlist = cats.Concat(dogs)
                              .Concat(fish);

            return petlist;
        }

        private Pet CreatePet(int weight, PetType petType)
        {
            var pet = fixture.Create<Pet>();
            pet.PetType = petType;
            pet.Weight = weight;

            return pet;
        }
    }

    public class GetHeaviestPetTest : FindHeaviestWithAverageWeightOfPetTypeTest
    {
        [Fact]
        public void ShouldReturnPetTypeDog()
        {
            var result = excercise2.FindTheHeaviestPetType(ienumerablePets);

            result.Should().Be(PetType.Dog);
        }
    }
}
