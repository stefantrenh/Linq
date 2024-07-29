using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Single
{
    public class SingleRefactorChallange
    {
        //TODO implement this method
        public static DateTime? GetSingleDay_Refactored(IEnumerable<DateTime> dates, DayOfWeek dayOfWeek)
        {
            return dates.Count(x => x.DayOfWeek == dayOfWeek) == 1 ? 
                dates.Single(x => x.DayOfWeek == dayOfWeek) : null;
        }

        //do not modify this method
        public static DateTime? GetSingleDay(IEnumerable<DateTime> dates, DayOfWeek dayOfWeek)
        {
            var count = 0;
            DateTime? result = null;
            foreach (var date in dates)
            {
                if (date.DayOfWeek == dayOfWeek)
                {
                    result = date;
                    count++;
                }
            }
            if (count == 1)
            {
                return result;
            }
            return null;
        }
    }
}
