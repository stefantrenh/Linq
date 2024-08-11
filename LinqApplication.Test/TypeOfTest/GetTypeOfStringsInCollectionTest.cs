using FluentAssertions;
using LinqApplication.LinqApplication.Library.TypeOf;

namespace LinqApplication.Test.TypeOfTest
{
    public class GetTypeOfStringsInCollectionTest
    {
        protected TypeOfExcercise2 excercise2;
        protected List<object> list;

        public GetTypeOfStringsInCollectionTest()
        {
            excercise2 = new TypeOfExcercise2();
            list = CreateObjectList();
        }

        private List<object> CreateObjectList()
        { 
            List<object> objectList = new List<object> {"AAA", "BBB", "CCC", 1, 2, 3.2414 ,null };

            return objectList;
        }
    }

    public class All_Strings_Are_UpperCase_In_Collection_Test : GetTypeOfStringsInCollectionTest
    {
        [Fact]
        public void Should_Return_True()
        {
            var result = excercise2.AreAllStringsUpperCase(list);

            result.Should().BeTrue();
        }
    }

    public class Collection_Contains_No_Strings_Test : GetTypeOfStringsInCollectionTest
    {
        [Fact]
        public void Should_Return_True() 
        {
            list.Clear();
            var result = excercise2.AreAllStringsUpperCase(list);

            result.Should().BeTrue();
        }
    }

    public class Collection_Contains_Word_With_LowerCase_Test : GetTypeOfStringsInCollectionTest
    {
        [Fact]
        public void Should_Return_False()
        {
            string lowerCaseWord = "aaa";
            list.Add(lowerCaseWord);

            var result = excercise2.AreAllStringsUpperCase(list);

            result.Should().BeFalse();
        }
    }
}
