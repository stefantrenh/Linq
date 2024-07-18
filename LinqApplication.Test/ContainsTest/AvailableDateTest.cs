using FluentAssertions;
using LinqApplication.LinqApplication.Library.Contains;


namespace LinqApplication.Test.ContainsTest
{
    public class AvailableDateTest
    {
        protected IEnumerable<DateTime> dates;
        protected ContainsExercise1 _containsExercise1;
        protected DateTime _existingDate = new DateTime(2024,07,18);

        public AvailableDateTest()
        {
           _containsExercise1 = new ContainsExercise1();
            dates = CreateDateList(5);
        }

        private IEnumerable<DateTime> CreateDateList(int count)
        { 
            var dates = new List<DateTime>();
            var random = new Random();

            var nextYear = DateTime.Now.AddYears(1).Year;
            var existingDate = new DateTime(2024,07,18);

            for (int i = 0; i < count - 1; i++)
            {
                var date = new DateTime(nextYear,
                    random.Next(1,12),
                    random.Next(1,29)
                    ) ;

                dates.Add(date);
            }

            dates.Add(existingDate);

            return dates.AsEnumerable();
        }
    }

    public class Date_Is_Available : AvailableDateTest
    {
        [Fact]
        public void Should_Return_True()
        {
            var date = DateTime.Now;

            var result = _containsExercise1.IsAppointmentDateAvailable(date,dates);

            result.Should().BeTrue();
        }
    }

    public class Date_Is_Not_Available : AvailableDateTest
    {
        [Fact]
        public void Should_Return_False()
        {
            var result = _containsExercise1.IsAppointmentDateAvailable(_existingDate, dates);

            result.Should().BeFalse();
        }
    }


}
