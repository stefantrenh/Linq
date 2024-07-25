﻿using AutoFixture;
using FluentAssertions;
using LinqApplication.LinqApplication.Domain.Entities;
using LinqApplication.LinqApplication.Library.Average;

namespace LinqApplication.Test.AverageTest
{
    public class AverageNumbersTest
    {
        protected AverageExercise2 exercise2;
        protected List<NumbersList> numbersList;
        protected Fixture fixture;
        public AverageNumbersTest()
        {
            exercise2 = new AverageExercise2();
            fixture = new Fixture();
            BuildMockData();
        }

        private void BuildMockData()
        {
            var numbersBuilder = fixture.Build<NumbersList>()
                .With(x => x.NumberIenumerable, fixture.CreateMany<int>(5)
                .Select(x => (x % 5) + 1).ToList());
            numbersList = numbersBuilder.CreateMany<NumbersList>(4).ToList();

            numbersList.Add(CreateNumbersListWithSpecificValues(5, 5));
        }

        private NumbersList CreateNumbersListWithSpecificValues(int count, int value)
        {
            return new NumbersList
            {
                NumberIenumerable = Enumerable.Repeat(value, count).ToList()
            };
        }
    }

    public class Has_Highest_Average_Number_Test : AverageNumbersTest 
    {
        [Fact]
        public void Should_Return_5 () 
        {
            var result = exercise2.MaxAverageOfMarks(numbersList);

            result.Should().Be(5);
        }
    }

    public class Has_No_Average_Data_Test : AverageNumbersTest
    {
        [Fact]
        public void Should_Return_0() 
        { 
            numbersList.Clear();

            var result = exercise2.MaxAverageOfMarks(numbersList);

            result.Should().Be(0);
        }
        
    }
}