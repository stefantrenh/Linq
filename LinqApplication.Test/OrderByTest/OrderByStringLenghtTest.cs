using AutoFixture;
using FluentAssertions;
using LinqApplication.LinqApplication.Library.OrderBy;


namespace LinqApplication.Test.OrderByTest
{
    public class OrderByStringLenghtTest
    {
        protected readonly List<string> _list;
        protected readonly OrderByExercise1 _orderByExercise1;

        public OrderByStringLenghtTest()
        {
            _list = new List<string>
            {
                "bb", "a", "ccc"
            };

            _orderByExercise1 = new OrderByExercise1();
        }
    }

    public class Wordlist_Are_OrderBy_Stringlenght_Desc : OrderByStringLenghtTest 
    {
        [Fact]
        public void Stringlist_Should_Be_Equal()
        {
            var sortedList = new List<string> { "ccc", "bb", "a" };
            
            var result = _orderByExercise1.OrderFromLongestToShortest(_list);

            result.Should().BeEquivalentTo(sortedList);
        }
    }
}
