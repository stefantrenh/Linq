namespace LinqApplication.LinqApplication.Library.Sum
{
    public class SumExcercise2
    {
        /*
        Implement the AverageSum method, 
        which given a nested collection of numbers (so a collection of collections of numbers) will return the average sum for those collections.
        For example, for the following input... 
        {
            {1,2,3,2}, //sum is 8
            {1,5,6}, //sum is 12
            {2,2} //sum is 4
        }
        ...the result shall be 8 because the average sum is (8+12+4)/3 = 8.
        Assume the result is not null and non-empty.
         */

        public double AverageSum(IEnumerable<IEnumerable<int>> collectionsOfNumbers)
        {
            return collectionsOfNumbers.Average(x => x.Sum());
        }
    }
}
