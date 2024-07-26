using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.ElementAt
{
    /*
     Using LINQ, implement the IsTheNumberAtIndexTheLargest method.
    This method should check if the number at the given index is the largest number in the collection.
    For example,  
    IsTheNumberAtIndexTheLargest (new int[] {1,2,4,4}, 0) should return false, 
    because the number at index 0 is 1, and it is not the largest in this collection.
    If there are other numbers equally large, the result should be true. 
    For example, IsTheNumberAtIndexTheLargest (new int[] {1,2,4,4}, 3) should return true, 
    because the number at index 3 has a value of 4, and it is one of the largest numbers in the collection.
    If no such index is present in the collection, the method should return false.
     */

    public class ElementAtExcercise1()
    {
        public bool IsTheNumberAtIndexTheLargest(IEnumerable<int> numbers, int index)
        {
            var validIEnumerable = index >= 0 && index < numbers.Count();

            return validIEnumerable ? numbers.Max() == numbers.ElementAt(index) : false;
        }
    }
}
