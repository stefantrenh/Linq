﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Count
{
    public class CountExercise1
    {
        /*
         Implement the CountAllLongWords method, which will count all words longer than 10 letters.
         */
        public int CountAllLongWords(IEnumerable<string> words)
        {
            return words.Count(x => x.Length > 10);
        }
    }
}
