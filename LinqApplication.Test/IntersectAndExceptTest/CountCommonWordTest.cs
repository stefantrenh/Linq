using FluentAssertions;
using LinqApplication.LinqApplication.Library.IntersectAndExcept;

namespace LinqApplication.Test.IntersectAndExceptTest
{
    public class CountCommonWordTest
    {
        protected string[] wordlist1;
        protected string[] wordlist2;
        protected IntersectAndExceptExcersie1 intersectAndExceptExcersie1;

        public CountCommonWordTest()
        {
            wordlist1 = new string[] { "aaa", "BBB", "CCC" };
            wordlist2 = new string[] { "aaa", "ccc", "DDD" };
            intersectAndExceptExcersie1 = new IntersectAndExceptExcersie1();
        }
    }

    public class CountTotalCommonWordsTest : CountCommonWordTest 
    {
        [Fact]
        public void ShouldReturnTwo()
        {
            var result = intersectAndExceptExcersie1.CountCommonWords(wordlist1, wordlist2);

            result.Should().Be(2);
        }
    }
}
