using AutoFixture;
using FluentAssertions;
using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Library.Average;


namespace LinqApplication.Test.AverageTest
{
    public class AverageSnowFallDataTest
    {
        protected readonly AverageExercise1 averageExercise1;
        protected SnowFallData snowFallData;
        protected Fixture fixture;

        public AverageSnowFallDataTest()
        {
            averageExercise1 = new AverageExercise1();
            fixture = new Fixture();
            snowFallData = fixture.Build<SnowFallData>()
                           .With(x => x.MonthlySnowFallDataItems, fixture.CreateMany<MonthlySnowFallData>(12).ToList())
                           .Create();
        }
    }

    public class AverageSnowFallTest : AverageSnowFallDataTest
    {
        [Fact]
        public void Should_Retrun_1()
        {
            for (int i = 0; i < snowFallData.MonthlySnowFallDataItems.Count; i++)
            {
                snowFallData.MonthlySnowFallDataItems[i].SnowfallInCentimeters = 1;
            }

            var result = averageExercise1.AverageSnowFall(snowFallData);

            result.Should().Be(1);
        }
    }

    public class Nullable_SnowFallDataTest : AverageSnowFallDataTest
    {
        [Fact]
        public void Should_Return_Null()
        {
            snowFallData = null;

            var result = averageExercise1.AverageSnowFall(snowFallData);

            result.Should().BeNull();
        }
    }

    public class Not_Enough_MonthlySnowFallData : AverageSnowFallDataTest 
    {
        [Fact]
        public void Should_Return_Null()
        { 
            snowFallData.MonthlySnowFallDataItems.RemoveAt(0);

            var result = averageExercise1.AverageSnowFall(snowFallData);

            result.Should().BeNull();
        }
    }

    public class Contiains_No_MonthlySnowFallData : AverageSnowFallDataTest
    {
        [Fact]
        public void Should_Return_Null() 
        {
            snowFallData.MonthlySnowFallDataItems = null;

            var result = averageExercise1.AverageSnowFall(snowFallData);

            result.Should().BeNull();
        }
    }
}
