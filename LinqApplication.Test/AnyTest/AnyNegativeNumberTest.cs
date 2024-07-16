using FluentAssertions;
using LinqApplication.LinqApplication.Library.Any;


namespace LinqApplication.Test.AnyTest
{
    public class AnyNegativeNumberTest
    {
        protected readonly AnyExercise1 anyExercise1;
        protected readonly int[] positiveNumbers;
        protected readonly int[] negativeNumbers;
        protected readonly int[] mixedNumbers;

        public AnyNegativeNumberTest()
        {
            anyExercise1 = new AnyExercise1();

            positiveNumbers = new int[]
            {
                10, 20, 30 , 40
            };

            negativeNumbers = new int[]
            {
                -10, -20, -30, -40
            };

            mixedNumbers = new int[]
            {
                -10, 20 , -30 , 40
            };
        }
    }

    public class Should_Return_False_No_NegativeNumbers : AnyNegativeNumberTest
    {
        [Fact]
        public void PositiveNumbers_Should_Return_False()
        {
            bool result = anyExercise1.IsAnyNumberNegative(positiveNumbers);

            result.Should().BeFalse();
        }
    }

    public class Should_Return_True_Contains_NegativeNumbers : AnyNegativeNumberTest
    {
        [Fact]
        public void NegativeNumbers_Should_Return_True()
        {
            bool result = anyExercise1.IsAnyNumberNegative(negativeNumbers);

            result.Should().BeTrue();
        }
    }

    public class Should_Return_True_Contains_MixedNumbers : AnyNegativeNumberTest
    {
        [Fact]
        public void MixedNumbers_Should_Return_True()
        {
            bool result = anyExercise1.IsAnyNumberNegative(mixedNumbers);

            result.Should().BeTrue();
        }
    }
}
