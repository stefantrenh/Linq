
using FluentAssertions;
using LinqApplication.LinqApplication.Library.All;

namespace LinqApplication.Test.AllTest
{
    public class AllDivisibleBy10Test
    {
        protected readonly AllExercise1 _exercise1;
        protected readonly int[] divisibleBy10;
        protected readonly int[] notDivisibleBy10;
        protected readonly int[] mixedNumbers;

        public AllDivisibleBy10Test()
        {
          _exercise1 = new AllExercise1();

            divisibleBy10 = new int[]
            {
                10, 20, 30, 40
            };

            notDivisibleBy10 = new int[]
            {
                11, 12, 13, 14
            };

            mixedNumbers = new int[]
            {
                -10, 21 , 30 , 44
            };
        }
    }

    public class Divisible_By_10 : AllDivisibleBy10Test 
    {
        [Fact]
        public void Should_Return_True()
        {
            var result = _exercise1.AreAllNumbersDivisibleBy10(divisibleBy10);

            result.Should().BeTrue();
        }
    }

    public class Not_Divisible_By_10 : AllDivisibleBy10Test
    {
        [Fact]
        public void Should_Return_False()
        {
            var result = _exercise1.AreAllNumbersDivisibleBy10(notDivisibleBy10);

            result.Should().BeFalse();
        }
    }

    public class Mixednumbers_Not_Divisible_by_10 : AllDivisibleBy10Test
    {
        [Fact]
        public void Should_Return_False()
        {
            var result = _exercise1.AreAllNumbersDivisibleBy10(mixedNumbers);

            result.Should().BeFalse();
        }
    }
}
