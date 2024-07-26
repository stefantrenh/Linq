using FluentAssertions;
using LinqApplication.LinqApplication.Library.OrderBy;

namespace LinqApplication.Test.OrderByTest
{
    public class OrderByChainedNumberTest
    {
        protected readonly int[] numberList;
        protected OrderByExercise2 orderByExercise2;

        public OrderByChainedNumberTest()
        {
           numberList = new int[] { 1, 2, 3, 4, 5, 6, 7 };
           orderByExercise2 = new OrderByExercise2();
        }
    }

    public class Should_OrderByDesc_Even_ThenByDesc_OddNumbers : OrderByChainedNumberTest
    {
        [Fact]
        public void Should_Return_Equal_Sorted_List()
        {
            var sortedList = new List<int> { 6, 4, 2, 7, 5, 3, 1 };
            var result = orderByExercise2.FirstEvenThenOddDescending(numberList);

            result.Should().BeEquivalentTo(sortedList);
            
        }
    }
}
