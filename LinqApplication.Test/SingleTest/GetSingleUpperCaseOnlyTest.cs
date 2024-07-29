using FluentAssertions;
using LinqApplication.LinqApplication.Library.Single;

namespace LinqApplication.Test.SingleTest
{
    public class GetSingleUpperCaseOnlyTest
    {
        protected SingleExcercise1 excercise1;
        protected List<string> wordList;

        public GetSingleUpperCaseOnlyTest()
        {
            wordList = new List<string> { "aaa", "BBB", "CcC" };
            excercise1 = new SingleExcercise1();
        }
    }

    public class Return_Single_Word_With_Only_Uppercase_Test : GetSingleUpperCaseOnlyTest 
    {
        [Fact]
        public void Should_Return_UpperCase_Word()
        {
            var result = excercise1.GetTheOnlyUpperCaseWord(wordList);

            result.Should().Be("BBB");
        }
    }

    public class Return_Null_When_No_Words_With_Uppercase_Test : GetSingleUpperCaseOnlyTest
    {
        [Fact]
        public void Should_Retrun_Null()
        {
            wordList[1] = wordList[1].ToLower();
            var result = excercise1.GetTheOnlyUpperCaseWord(wordList);

            result.Should().BeNull();
        }
    }

    public class Contains_More_Uppercase_Words_Than_One_Test : GetSingleUpperCaseOnlyTest
    {

        [Fact]
        public void Should_Throw_Exception()
        {
            for (int i = 0; i < wordList.Count; i++)
            {
                wordList[i] = wordList[i].ToUpper();
            }

            Action act = () => excercise1.GetTheOnlyUpperCaseWord(wordList);

            act.Should().Throw<Exception>();
        }
    }
}
