using AutoFixture;
using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Library.All;
using LinqApplication.LinqApplication.Domain.Enums;
using FluentAssertions;

namespace LinqApplication.Test.AllTest
{
    public class AllPetTypesAreTheSameTest
    {
        protected readonly Fixture _fixure;
        protected readonly AllExercise2 _exercise2;
        protected List<Pet> _pets;

        public AllPetTypesAreTheSameTest()
        {
            _fixure = new Fixture();
            _exercise2 = new AllExercise2();
            _pets = _fixure.CreateMany<Pet>(5).ToList();
        }
    }

    public class All_Pets_Are_The_Same : AllPetTypesAreTheSameTest
    {
        [Fact]
        public void Should_Return_True()
        { 
            _pets.ForEach(pet => { pet.PetType = PetType.Cat; });

            var result = _exercise2.AreAllPetsOfTheSameType(_pets);

            result.Should().BeTrue();
        }
    }

    public class All_Pets_Are_Not_The_Same : AllPetTypesAreTheSameTest
    {
        [Fact]
        public void Should_Return_False() 
        {
            _pets[0].PetType = PetType.Dog;
            _pets[1].PetType = PetType.Cat;

            var result = _exercise2.AreAllPetsOfTheSameType(_pets);

            result.Should().BeFalse();
        }
    }
}
