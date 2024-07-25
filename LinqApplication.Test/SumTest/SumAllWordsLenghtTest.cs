using FluentAssertions;
using LinqApplication.LinqApplication.Library.Sum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.Test.SumTest
{
    public class SumAllWordsLenghtTest
    {
        protected SumExcercise1 sumExcercise1;
        protected List<string> words;

        public SumAllWordsLenghtTest()
        {
            words = new List<string> { "a", "bb", "ccc", "dddd" };
            sumExcercise1 = new SumExcercise1();
        }
    }

    public class Count_Lenght_Of_Words_Test : SumAllWordsLenghtTest 
    {
        [Fact]
        public void Should_Return_Sum_Of_10()
        {
            var result = sumExcercise1.TotalLength(words);

            result.Should().Be(10);
        }
    }
}
