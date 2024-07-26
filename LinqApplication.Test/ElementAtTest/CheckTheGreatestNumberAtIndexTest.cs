using FluentAssertions;
using LinqApplication.LinqApplication.Library.ElementAt;

namespace LinqApplication.Test.ElementAtTest
{
    public class CheckTheGreatestNumberAtIndexTest
    {
        protected List<int> numbers;
        protected ElementAtExcercise1 excercise1;

        public CheckTheGreatestNumberAtIndexTest()
        {
            numbers = new List<int> { 1, 2, 3, 4 };
            excercise1 = new ElementAtExcercise1();
        }
    }

    public class Pick_The_Largest_Number_Test : CheckTheGreatestNumberAtIndexTest 
    {
        [Fact]
        public void Should_Return_True()
        {
            var result = excercise1.IsTheNumberAtIndexTheLargest(numbers, 3);

            result.Should().BeTrue();
        }
    }

    public class Pick_The_Lowest_Number_Test : CheckTheGreatestNumberAtIndexTest
    {
        [Fact]
        public void Should_Return_False()
        {
            var result = excercise1.IsTheNumberAtIndexTheLargest(numbers, 0);

            result.Should().BeFalse();
        }
    }
}
