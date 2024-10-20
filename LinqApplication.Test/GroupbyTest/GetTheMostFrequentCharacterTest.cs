using FluentAssertions;
using LinqApplication.LinqApplication.Library.GroupBy;

namespace LinqApplication.Test.GroupbyTest
{
    public class GetTheMostFrequentCharacterTest
    {
        protected string word = "slussen";
        protected GroupByExercise1 groupByExercise1;

        public GetTheMostFrequentCharacterTest()
        {
            groupByExercise1 = new GroupByExercise1();
        }
    }

    public class GetMostFrequentCharInStringTest : GetTheMostFrequentCharacterTest 
    {
        [Fact]
        public void ShouldBeEquvalent()
        {
            char s = 's';

            var result = groupByExercise1.GetTheMostFrequentCharacter(word);

            result.Should().BeEquivalentTo(s);
        }
    }
}
