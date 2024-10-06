using FluentAssertions;
using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Library.SelectMany;

namespace LinqApplication.Test.SelectManyTest
{
    public class TopFiveStudentsMarkTest
    {
        protected List<Student> _studentList;
        protected SelectManyExcercise2 studentSelectMany;

        public TopFiveStudentsMarkTest()
        {
            _studentList = new List<Student>
                          {
                             new Student { Marks = new List<int> { 3,6,2,6 } , Name = "Lucy" },
                             new Student { Marks = new List<int> { 4,5 } , Name = "Tom" },
                             new Student { Marks = new List<int> { 3,3,5 } , Name = "Alice" },
                             new Student { Marks = new List<int> { 2,3,3 } , Name = "Brian" }
                          };

            studentSelectMany = new SelectManyExcercise2();
        }
    }

    public class CreateListOfTopStudentsMarkTest() : TopFiveStudentsMarkTest
    {
        [Fact]
        public void ShouldReturnStudentList()
        {
            IEnumerable<string> studentList = new List<string> { "Lucy: 6","Lucy: 6","Alice: 5","Tom: 5","Tom: 4" };

            var result = studentSelectMany.BestMarksAndStudents(_studentList);

            result.Should().BeEquivalentTo(studentList);
        }
    }
}
