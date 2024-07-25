using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Sum
{
    public class SumRefactorChallange
    {
        //TODO implement this method
        public static bool HasAnyStudentSumOfMarksLargerThan100_Refactored(IEnumerable<Student> students)
        {
            return students.Any(x => x.Marks.Sum() > 100); 
        }

        //do not modify this method
        public static bool HasAnyStudentSumOfMarksLargerThan100(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                var sumOfMarks = 0;
                foreach (var mark in student.Marks)
                {
                    sumOfMarks += mark;
                }
                if (sumOfMarks > 100)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class Student
    {
        public IEnumerable<int> Marks { get; set; }
    }

}
