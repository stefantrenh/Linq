using FluentAssertions;
using LinqApplication.LinqApplication.Library.MinMax;


namespace LinqApplication.Test.MinMaxTest
{
    public class LenghtOfShortestStringTest
    {
        protected string[] words;
        protected string[] nullableStringArray;
        protected MinMaxExcercise1 excercise1;

        public LenghtOfShortestStringTest()
        {
            words = new string[] { "aa", "ccc", "b" };
            excercise1 = new MinMaxExcercise1();
        }
    }

    public class Shortest_String_String_Test : LenghtOfShortestStringTest
    {
        [Fact]
        public void Should_Return_One()
        { 
            var result = excercise1.LengthOfTheShortestWord(words);

            result.Should().Be(1);
        }
    }

    public class Empty_String_Array_Should_Return_Null : LenghtOfShortestStringTest 
    { 
        public void Should_Return_Null() 
        {
            var result = excercise1.LengthOfTheShortestWord(nullableStringArray);

            result.Should().BeNull();
        }
    }

}
