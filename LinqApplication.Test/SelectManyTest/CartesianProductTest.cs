using FluentAssertions;
using LinqApplication.LinqApplication.Library.SelectMany;

namespace LinqApplication.Test.SelectManyTest
{
    public class CartesianProductTest
    {
        protected HashSet<int> ints;
        protected SelectManyExcercise1 selectManyExcercise1;

        public CartesianProductTest()
        {
            ints = new HashSet<int> { 1, 2, 5 };
            selectManyExcercise1 = new SelectManyExcercise1();
        }
    }

    public class BuildCartesianProductTest : CartesianProductTest 
    {
        [Fact]
        public void ShouldReturnCartesianProduct()
        {
            IEnumerable<string> cartesianList = new List<string> { "1,1", "1,2", "1,5", "2,1", "2,2", "2,5", "5,1", "5,2", "5,5" };

            var result = selectManyExcercise1.BuildCartesianProduct(ints);

            result.Should().BeEquivalentTo(cartesianList);
        }
    }
}
