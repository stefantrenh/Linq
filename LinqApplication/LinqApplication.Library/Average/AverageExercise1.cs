using LinqApplication.LinqApplication.Domain.Entities;


namespace LinqApplication.LinqApplication.Library.Average
{

    /*
    Let's define a class SnowFallData that holds the information about snowfall in months of a given year. 

    For example, for the year 2020, we could have:
        20 centimeters of snowfall in January
        25 centimeters  in February
        5 centimeters  in March
        0 centimeters  in April

    etc.  
    Implement the AverageSnowFall method that will calculate the average snowfall in centimeters for a given SnowFallData object. 
    This method should return null if the object is null, 
    or its monthly snowfall data is null or the count of MonthlySnowFallDataItems is not 12 (one for each month).
     */

    public class AverageExercise1
    {
        public float? AverageSnowFall(SnowFallData snowFallData)
        {
            return isVaild(snowFallData)
                ? snowFallData.MonthlySnowFallDataItems.Average(x => x.SnowfallInCentimeters) : null; 
        }

        private bool isVaild(SnowFallData snowFallData)
        {
            return snowFallData != null &&
                snowFallData.MonthlySnowFallDataItems != null &&
                snowFallData.MonthlySnowFallDataItems.Count() == 12;
        }
    }
}
