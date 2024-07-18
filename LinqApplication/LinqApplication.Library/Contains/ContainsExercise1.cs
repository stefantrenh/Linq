using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Contains
{
    public class ContainsExercise1
    {
        public bool IsAppointmentDateAvailable(DateTime date, IEnumerable<DateTime> existingAppointmentDates)
        {
            return !existingAppointmentDates.Contains(date);
        }
    }
}
