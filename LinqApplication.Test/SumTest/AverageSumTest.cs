using FluentAssertions;
using LinqApplication.LinqApplication.Library.Sum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.Test.SumTest
{
    public class AverageSumTest
    {
        protected SumExcercise2 sumExcercise2;
        protected List<List<int>> numberLists;

        public AverageSumTest()
        {
            sumExcercise2 = new SumExcercise2();
            numberLists = CreateNumberLists();
        }

        [Fact]
        public void Average_Should_Return_5()
        {
            var result = sumExcercise2.AverageSum(numberLists);

            result.Should().Be(5);
        }

        private List<List<int>> CreateNumberLists()
        { 
            var list = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                list.Add(new List<int> { 1, 1, 1, 1, 1 });
            }

            return list;
        }
    }

    
}
