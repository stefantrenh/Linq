using FluentAssertions;
using LinqApplication.LinqApplication.Library.Single;

namespace LinqApplication.Test.SingleTest
{
    public class GetSingleListTest
    {
        protected SingleExercise2 exercise2;
        protected List<List<int>> numbers;

        public GetSingleListTest()
        {
            numbers = new List<List<int>> { new List<int> { 1 }, new List<int> { 1, 2 , 3 }, };
            exercise2 = new SingleExercise2();
        }
    }

    public class Get_Single_Number_List_Test : GetSingleListTest 
    {
        [Fact]
        public void Should_Return_Single_Number_List()
        { 
            var numberList = new List<int> { 1 };

            var result = exercise2.GetSingleElementCollection(numbers);

            result.Should().BeEquivalentTo(numberList);
        }
    }

    public class Contains_More_Than_One_Single_Element_Collection : GetSingleListTest
    {
        [Fact]
        public void Should_Throw_Exception()
        { 
            var singleElementCollection = new List<int> { 2 };
            numbers.Add(singleElementCollection);

            Action action = () => exercise2.GetSingleElementCollection(numbers);

            action.Should().Throw<Exception>();

        }
    }

    public class Contains_No_Single_Element_In_Collection : GetSingleListTest
    {
        [Fact]
        public void Should_Throw_Exception()
        { 
            numbers.RemoveAt(0);

            Action action = () => exercise2.GetSingleElementCollection(numbers);

            action.Should().Throw<Exception>();
        }
        
    }

}
