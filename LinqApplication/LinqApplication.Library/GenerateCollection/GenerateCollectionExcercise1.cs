using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.GenerateCollection
{
    /*
     Implement the NewYearsEvesSince method, which given an initialYear and yearsCount parameters, will build a dictionary with the key being the year, and the value being the day of the week (as string) of the New Year's Eve. Please assume the New Year's Eve is on the 31st of December (according to the Gregorian calendar).

        For example, for initialYear 1900 and yearsCount 5, the result shall be a dictionary with the following keys and values:
        
        [1900] = "Monday" ,       
        [1901] = "Tuesday",      
        [1902] = "Wednesday",       
        [1903] = "Thursday",      
        [1904] = "Saturday"
        
        As you can see this dictionary contains 5 elements because the yearsCount parameter was set to 5.
     */
    public class GenerateCollectionExcercise1
    {
        public Dictionary<int, string> NewYearsEvesSince(int initialYear, int yearsCount)
        {
            return Enumerable.Range(initialYear, yearsCount)
                             .ToDictionary(year => year,
                             year => new DateTime(year, 12 ,31).DayOfWeek.ToString()); 
        }
    }
}
