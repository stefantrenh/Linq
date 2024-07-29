using AutoFixture;
using FluentAssertions;
using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Library.FirstAndLast;

namespace LinqApplication.Test.FirstAndLastTest
{
    public class GetYoungestPersonTest
    {
        protected Fixture fixture;
        protected FirstAndLastExcercise2 firstAndLastExcercise2;
        protected List<Person> people;

        public GetYoungestPersonTest()
        {
            fixture = new Fixture();
            firstAndLastExcercise2 = new FirstAndLastExcercise2();
            people = CreatePersonMockData(5);
        }

        [Fact]
        public void Should_Return_Youngest_Person_With_Specific_DateOfBirth()
        {
            var expectedYoungestDateOfBirth = new DateTime(2024,1,5);

            var result = firstAndLastExcercise2.GetYoungest(people);

            result.DateOfBirth.Should().Be(expectedYoungestDateOfBirth);
        }

        private List<Person> CreatePersonMockData(int count)
        {
            var startDate = new DateTime(2024, 1, 1);
            var dates = Enumerable.Range(0, count)
                                  .Select(i => startDate.AddDays(i))
                                  .ToList();

            var peopleList = new List<Person>();

            foreach (var date in dates)
            {
                var person = fixture.Build<Person>()
                                    .With(x => x.DateOfBirth, date)
                                    .Create();

                peopleList.Add(person);
            }

            return peopleList;
        }
    }
}
