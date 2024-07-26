using AutoFixture;
using FluentAssertions;
using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Library.ElementAt;

namespace LinqApplication.Test.ElementAtTest
{
    public class CheckPetElementAtIndexTest
    {
        protected Fixture fixture;
        protected List<Pet> pets;
        protected ElementAtExcercise2 excercise2;

        public CheckPetElementAtIndexTest()
        {
            fixture = new Fixture();
            pets = fixture.CreateMany<Pet>(5).ToList();
            excercise2 = new ElementAtExcercise2();
        }

        public string CreateReturnDataString(List<Pet> pet, int index)
        {
            if (pet[index].Name != null)
            {
                return $"Pet name: {pet[index].Name}";
            }
            else
            {
                return $"Pet data is missing for index {index}";
            }
        }
    }

    public class Check_If_PetName_Exists_Test : CheckPetElementAtIndexTest
    {
        [Fact]
        public void Should_Return_PetName()
        {
            var result = excercise2.FormatPetDataAtIndex(pets, 1);

            result.Should().BeEquivalentTo(CreateReturnDataString(pets,1));
        }
    }

    public class Return_Message_If_PetName_Dont_Exists_Test : CheckPetElementAtIndexTest
    {
        [Fact]
        public void Should_Return_Missing_Message()
        {
            pets[1].Name = null;
            var result = excercise2.FormatPetDataAtIndex(pets, 1);

            result.Should().BeEquivalentTo(CreateReturnDataString(pets, 1));
        }
    }
}
