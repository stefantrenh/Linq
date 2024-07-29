using AutoFixture;
using FluentAssertions;
using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Library.Where;

namespace LinqApplication.Test.WhereTest
{
    public class GetStudentsWithAverageMarkTest
    {
        protected Fixture fixture;
        protected List<Student> students;
        protected WhereExercise1 exercise1;

        public GetStudentsWithAverageMarkTest()
        {
            fixture = new Fixture();

            var counter = 0;
            students = fixture.Build<Student>()
                       .Without(m => m.Marks)
                       .CreateMany<Student>(3)
                       .Select((m, i) => { m.Marks = new List<int> { 4, 4, 6 + i + 1 }; return m; })
                       .ToList();

            exercise1 = new WhereExercise1();
        }
    }

    public class Get_Students_With_Average_4dot6_Marks_Test : GetStudentsWithAverageMarkTest 
    {
        [Fact]
        public void Should_Return_Count_Of_Three()
        {
            var result = exercise1.GetScholarshipCandidates(students).Count();

            result.Should().Be(3);
        }
    }

    public class Get_Student_With_No_Marks_At_Elements_Test : GetStudentsWithAverageMarkTest
    {
        [Fact]
        public void Should_Return_An_Empty_Collection()
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i].Marks = new List<int>();
            }

            var result = exercise1.GetScholarshipCandidates(students);

            result.Should().BeEmpty();
        }
        
    }


}
