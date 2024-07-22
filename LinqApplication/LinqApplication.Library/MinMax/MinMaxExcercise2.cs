﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.MinMax
{

    /*
     Using LINQ, implement the CountOfLargestNumbers method, 
    which will check how many numbers in the collection are equal to the largest number in this collection. 
    For an empty collection, the result should be 0.

    For example:
    for {3,2,2,4,4,0} the result will be 2. 
    The largest number in the collection is four, and there are two fours in this collection

    for {3,2,2,4,0} the result will be 1. 
    The largest number in the collection is four, and there is a single four in this collection

    for {} the result will be 0
     */
    public class MinMaxExcercise2
    {
        public int CountOfLargestNumbers(IEnumerable<int> numbers)
        { 
            return numbers.Any() ? numbers.Count(x => x == numbers.Max()) : 0;
        }
    }
}
