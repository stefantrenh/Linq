using FluentAssertions;
using LinqApplication.LinqApplication.Library.FirstAndLast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.Test.FirstAndLastTest
{
    public class FindFirstNameTest
    {
        protected List<string> names;
        protected FirstAndLastExcercise1 firstAndLastExcercise1;

        public FindFirstNameTest()
        {
            names = new List<string> { "SteFAN", "Cindy", "Louie", "ToMbu", "Louis", "LUUULEE", "Leah" };
            firstAndLastExcercise1 = new FirstAndLastExcercise1();
        }
    }

    public class Find_First_Valid_Name : FindFirstNameTest
    {
        [Fact]
        public void Should_Return_Cindy()
        {
            var result = firstAndLastExcercise1.FindFirstNameInTheCollection(names);

            result.Should().BeEquivalentTo("Cindy");
        }
    }

    public class Empty_List : FindFirstNameTest 
    {
        [Fact]
        public void Should_Return_null()
        { 
            names.Clear();

            var result = firstAndLastExcercise1.FindFirstNameInTheCollection(names);

            result.Should().BeNull();
        }
    }
}
