using FluentAssertions;
using LinqApplication.LinqApplication.Library.Distinct;

namespace LinqApplication.Test.DistinctTest
{
    public class DoesItContainsAnyDuplicateDataTypeTest
    {
        protected DistinctExcercise1 excercise1;
        protected List<string> stringList;
        protected List<int> intList;

        public DoesItContainsAnyDuplicateDataTypeTest()
        {
            stringList = new List<string> {"AAA", "BBB", "BBB", "CCC" };
            intList = new List<int> { 1, 2, 3, 4 };
            excercise1 = new DistinctExcercise1();
        }
    }

    public class No_Duplicate_Numbers_Test : DoesItContainsAnyDuplicateDataTypeTest 
    {
        [Fact]
        public void Should_Return_True()
        {
            var result = excercise1.AreAllUnique(intList);

            result.Should().BeTrue();
        }
    }

    public class Has_Duplicate_Numbers_Test : DoesItContainsAnyDuplicateDataTypeTest
    {
        [Fact]
        public void Should_Return_True()
        {
            var result = excercise1.AreAllUnique(stringList);

            result.Should().BeFalse();
        }
    }
}
