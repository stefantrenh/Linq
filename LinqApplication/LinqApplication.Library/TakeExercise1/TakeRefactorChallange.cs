using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.TakeExercise1
{
    public class TakeRefactorChallange
    {
        public class Exercise
        {
            //TODO implement this method
            public static IEnumerable<DateTime> GetDatesBeforeXXCentury_Refactored(IEnumerable<DateTime> dates)
            {
                return dates.TakeWhile(x => x.Year < 1901);
            }

            //do not modify this method
            public static IEnumerable<DateTime> GetDatesBeforeXXCentury(IEnumerable<DateTime> dates)
            {
                var result = new List<DateTime>();
                foreach (var date in dates)
                {
                    if (date.Year < 1901)
                    {
                        result.Add(date);
                    }
                    else
                    {
                        break;
                    }
                }
                return result;
            }
        }
    }
}
