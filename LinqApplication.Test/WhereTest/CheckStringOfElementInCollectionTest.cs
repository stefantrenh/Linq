using FluentAssertions;
using LinqApplication.LinqApplication.Library.Where;

namespace LinqApplication.Test.WhereTest
{
    public class CheckStringOfElementInCollectionTest
    {
        protected WhereExcercise2 excercise2;
        protected List<string> indexWords;

        public CheckStringOfElementInCollectionTest()
        {
            excercise2 = new WhereExcercise2();
            indexWords = new List<string> { "1.AAA", "2.BBB", "4.CCC" };
        }

        [Fact]
        public void Should_Return_Indexwords_Plus_One()
        {
            var validIndexWords = new List<string> { "1.AAA", "2.BBB" };

            var result = excercise2.GetProperlyIndexedWords(indexWords);

            result.Should().BeEquivalentTo(validIndexWords);
        }
    }
}
