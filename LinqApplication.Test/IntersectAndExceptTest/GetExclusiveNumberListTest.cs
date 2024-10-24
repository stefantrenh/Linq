using FluentAssertions;
using LinqApplication.LinqApplication.Library.IntersectAndExcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.Test.IntersectAndExceptTest
{
    public class GetExclusiveNumberListTest
    {
        protected List<int> numberlist1;
        protected List<int> numberlist2;
        protected IntersectAndExceptExcercise2 intersectAndExceptExcercise2;

        public GetExclusiveNumberListTest()
        {
            numberlist1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            numberlist2 = new List<int> { 9, 8, 7, 6, 5 };
            intersectAndExceptExcercise2 = new IntersectAndExceptExcercise2();
        }
    }

    public class GetListTest : GetExclusiveNumberListTest
    {
        [Fact]
        public void ShouldBeEquvalentToMockedList()
        {
            var mocklist = new List<int> { 1, 2, 3, 4, 7, 8, 9 };

            var result = intersectAndExceptExcercise2.GetExclusiveNumbers(numberlist1, numberlist2);

            result.Should().BeEquivalentTo(mocklist);
        }
    }
}
