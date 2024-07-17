using AutoFixture;
using FluentAssertions;
using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Domain.Enums;
using LinqApplication.LinqApplication.Library.Any;

namespace LinqApplication.Test.AnyTest
{
    public class AnyGreaterThanAmountTest
    {
        protected Fixture _fixture;
        protected List<Pet> _pets;
        protected AnyExercise2 _exercise2;

        public AnyGreaterThanAmountTest()
        {
            _fixture = new Fixture();
            _pets = _fixture.CreateMany<Pet>(3).ToList();
            _exercise2 = new AnyExercise2();
        }
    }

    public class Contains_Big_Cats_Should_Return_True : AnyGreaterThanAmountTest 
    {
        [Fact]
        public void Should_Return_True_Contains_Big_Cats()
        {
            _fixture.Build<Pet>()
                .With(p => p.PetType, PetType.Cat)
                .With(p => p.Weight, 3f)
                .Create();

            var result = _exercise2.AreThereAnyBigCats(_pets);

            result.Should().BeTrue();
        }      
    }

    public class Contains_Only_Small_Cats_Should_Return_False : AnyGreaterThanAmountTest
    {
        [Fact]
        public void Should_Return_False_Contains_Small_Cats()
        {
            foreach (var pet in _pets)
            {
                pet.Weight = 1;
                pet.PetType = PetType.Cat;
            }
            var result = _exercise2.AreThereAnyBigCats(_pets);

            result.Should().BeFalse();
        }
    }


}
