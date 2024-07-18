using AutoFixture;
using FluentAssertions;
using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Library.Contains;
using System.Xml.XPath;


namespace LinqApplication.Test.ContainsTest
{
    public class NestedCountTest
    {
        protected readonly Fixture _fixture;
        protected List<Person> _people;
        protected readonly List<Friend> _friend;
        protected ContainsExercise2 _exercise2;


        public NestedCountTest()
        {
            _fixture = new Fixture();
            _people = _fixture.CreateMany<Person>(5).ToList();
            _exercise2 = new ContainsExercise2();
            _friend = new List<Friend> { _fixture.Create<Friend>() };
        }
    }

    public class Contains_Three_Friends : NestedCountTest
    {
        [Fact]
        public void Should_Return_Count_Of_Three()
        {
            for (int i = 0; i < 3; i++) 
            {
                _people[i].Friends = _friend;
            }

            var result = _exercise2.CountFriendsOf(_friend.First(), _people);

            result.Should().Be(3);
        }
        
    }

    public class Contains_No_Friends : NestedCountTest 
    {
        [Fact]
        public void Should_Return_Count_Of_Zero()
        {
            var result = _exercise2.CountFriendsOf(_friend.First(), _people);

            result.Should().Be(0);
        }
    }
    

}
