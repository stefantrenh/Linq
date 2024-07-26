using FluentAssertions;
using LinqApplication.LinqApplication.Library.MinMax;

namespace LinqApplication.Test.MinMaxTest
{
    public class CountTotalMaxNumbersInListTest
    {
        protected IEnumerable<int> numberList;
        protected MinMaxExcercise2 excercise2;

        public CountTotalMaxNumbersInListTest()
        {
            numberList = new List<int> { 3 ,2 ,2 ,4 ,4 ,0 };
            excercise2 = new MinMaxExcercise2();
        }
    }

    public class Max_Number_Sequence : CountTotalMaxNumbersInListTest 
    {
        [Fact]
        public void Should_Return_2()
        {
            var result = excercise2.CountOfLargestNumbers(numberList);

            result.Should().Be(2);
        }
    }

    public class Empty_Number_List : CountTotalMaxNumbersInListTest
    {
        [Fact]
        public void Should_Return_0() 
        {
            numberList = new List<int>();

            var result = excercise2.CountOfLargestNumbers(numberList);

            result.Should().Be(0);
        }
        
    }
}
