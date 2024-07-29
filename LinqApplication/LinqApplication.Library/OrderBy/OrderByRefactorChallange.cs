namespace LinqApplication.LinqApplication.Library.OrderBy
{
    public class OrderByRefactorChallange
    {
        //TODO implement this method
        public static IEnumerable<DateTime> OrderByMonth_Refactored(List<DateTime> dates)
        {
            return dates.OrderBy(x => x.Month);
        }

        //do not modify this method
        public static IEnumerable<DateTime> OrderByMonth(List<DateTime> dates)
        {
            dates.Sort((left, right) =>
            {
                return left.Month.CompareTo(right.Month);
            });
            return dates;
        }
    }
}
