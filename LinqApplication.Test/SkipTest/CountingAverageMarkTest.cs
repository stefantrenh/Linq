using AutoFixture;
using FluentAssertions;
using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Library.Skip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.Test.SkipTest
{
    public class CountingAverageMarkTest
    {
        protected Fixture fixture;
        protected SkipExercise1 skipExercise;
        protected Student student;
        public CountingAverageMarkTest()
        {
            fixture = new Fixture();
            skipExercise = new SkipExercise1();
            student = fixture.Build<Student>()
                             .With(mark => mark.Marks, new List<int> { 1, 1, 1, 1 })
                             .Create();
        }


        [Fact]
        public void Should_Return_Average_Value_One()
        {
            var result = skipExercise.CalculateAverageMark(student);

            result.Should().Be(1);
        }


    }
}
