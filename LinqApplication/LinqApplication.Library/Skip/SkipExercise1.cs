using LinqApplication.LinqApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Skip
{

    /*
     Let's define a Student class. A student has a collection of Marks, which are numbers. Implement the CalculateAverageMark method, which will calculate the average mark for a student, but it will ignore the lowest and the highest mark. Let's assume a student with fewer than 3 marks has an average mark of 0.
    For example:
        John has the following marks: 3,4,6,6,2,5. 
        We want to ignore one highest mark (6) and one lowest mark (2). 
        That means, we want to calculate the average of 3,4,6,5, which is 4.5
        Assume the marks of the student are not null.
     */
    public class SkipExercise1
    {
        public double CalculateAverageMark(Student student)
        {       
            return student.Marks.Count() > 2 ? 
                   student.Marks.OrderBy(x => x).Skip(1).SkipLast(1).Average() : 0;
        }
    }
}
