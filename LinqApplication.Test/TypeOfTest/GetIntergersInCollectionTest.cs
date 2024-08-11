using FluentAssertions;
using LinqApplication.LinqApplication.Library.TypeOf;

namespace LinqApplication.Test.TypeOfTest
{
    public class GetIntergersInCollectionTest
    {
        protected List<object> list;
        protected TypeOfExercise1 typeOfExercise1;

        public GetIntergersInCollectionTest()
        {
            typeOfExercise1 = new TypeOfExercise1();
            list = CreateObjectList();
        }

        private List<object> CreateObjectList()
        { 
            var objectList = new List<object> { "string", 1, 2.2131, null };

            return objectList;
        }
    }

    public class Get_Int_Test : GetIntergersInCollectionTest
    {
        [Fact]
        public void Should_Return_Int_In_Collection()
        {
            var result = typeOfExercise1.GetTheFirstInteger(list);

            var typeOfResult = result.GetType();

            typeOfResult.Should().Be(typeof(int));
        }
    }

    public class Contains_No_Ints_In_Collection : GetIntergersInCollectionTest
    {
        [Fact]
        public void Should_Return_Null()
        {
            string object1 = "hej";
            list.Clear();
            list.Add(object1);

            var result = typeOfExercise1.GetTheFirstInteger(list);

            result.Should().BeNull();
        }
    }
}
