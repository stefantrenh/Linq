﻿namespace LinqApplication.LinqApplication.Library.Contains
{
    public class ContainsExercise1
    {
        /*
         Using LINQ, implement the IsAppointmentDateAvailable method. This method takes two parameters: date of an appointment, 
        and existingAppointmentDates, which is a collection of dates that are already taken. 
           
        This method should return true only if the date is not amongst the existingAppointmentDates.
        For example, for the following existingAppointmentDates:
            new DateTime(2022, 1, 11),
            new DateTime(2022, 1, 12)

        ...and the date parameter equal to new DateTime(2022, 1, 10), the result shall be true, because the date is not present in the existingAppointmentDates.

        On the other hand, for the following existingAppointmentDates:
            new DateTime(2022, 1, 11),
            new DateTime(2022, 1, 10)

        ...and the date parameter equal to new DateTime(2022, 1, 10), the result shall be false, because the date is present in the existingAppointmentDates.         
         */
        public bool IsAppointmentDateAvailable(DateTime date, IEnumerable<DateTime> existingAppointmentDates)
        {
            return !existingAppointmentDates.Contains(date);
        }
    }
}
