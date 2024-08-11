using FluentAssertions;
using LinqApplication.LinqApplication.Library.Skip;

namespace LinqApplication.Test.SkipTest
{
    public class TakeWordsTest
    {
        protected SkipExercise2 skipExercise2;
        protected List<string> validWords;
        protected List<string> inValidWords;

        public TakeWordsTest()
        {
            validWords = new List<string> { "aaa", "START" , "bbb" , "ccc" , "END" ,"ddd"};
            inValidWords = new List<string> { "aaa", "bbb", "ccc", "END" ,"ddd"};
            skipExercise2 = new SkipExercise2();
        }


    }

    public class Get_Valid_Words_Test : TakeWordsTest 
    {
        [Fact]
        public void Should_Return_Word_List()
        {
            var validWordList = new List<string> { "bbb", "ccc" };
            var result = skipExercise2.GetWordsBetweenStartAndEnd(validWords);

            result.Should().BeEquivalentTo(validWordList);
        }
    }

    public class Unvalid_Words_Test : TakeWordsTest 
    {
        [Fact]
        public void Should_Return_Empty_Collection()
        {
            var result = skipExercise2.GetWordsBetweenStartAndEnd(inValidWords);

            result.Should().BeEmpty();
        }
    }

}
