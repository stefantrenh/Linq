using AutoFixture;
using FluentAssertions;
using LinqApplication.LinqApplication.Library.GenerateCollection;
using Xunit;

namespace LinqApplication.Test.GenerateCollectionTest
{
    public class GetDayFromNewYearsEveTest
    {
        protected readonly GenerateCollectionExcercise1 generateCollectionExcercise1;
        protected readonly Dictionary<int, string> daysOfNewYearEve;
        protected readonly Fixture fixture;

        public GetDayFromNewYearsEveTest()
        {
            fixture = new Fixture();
            generateCollectionExcercise1 = new GenerateCollectionExcercise1();
            daysOfNewYearEve = BuildNewYearsEveKeyPairData(2000,5);
        }

        private Dictionary<int, string> BuildNewYearsEveKeyPairData(int initialYear, int yearsCount)
        { 
            var dictionary = new Dictionary<int, string>();

            var years = fixture.CreateMany<int>(yearsCount)
                               .Select((_, index) => initialYear + index)
                               .ToList();

            var daysOfWeek = years.Select(year => new DateTime(year,12,31).DayOfWeek.ToString())
                                  .ToList();


            dictionary = years.Zip(daysOfWeek, (key, value) => new { key, value })
                               .ToDictionary(x => x.key, x => x.value);

            return dictionary;
        }
    }

    public class  CreateDaysOfNewYearsEveToDictionaryTest : GetDayFromNewYearsEveTest
    {
        [Fact]
        public void ShouldBeEquvalent()
        {
            var result = generateCollectionExcercise1.NewYearsEvesSince(2000,5);

            result.Should().BeEquivalentTo(daysOfNewYearEve);
        }
    }
}
