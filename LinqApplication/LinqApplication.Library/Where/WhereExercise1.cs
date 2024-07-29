using LinqApplication.LinqApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Where
{

    /*
     Let's define a Student class. A student has a collection of Marks, which are numbers. 
    We could calculate the average mark for each student, 
    for example, if a student's marks are 3,4,5, the average mark for this student is 4.

    Implement the GetScholarshipCandidates method, which will find all those students, whose average mark is above 4.6.

    For example, let's consider students:

        Cathy has marks 4,4,6 which gives an average of 4.66
        Martin has marks 5,5,5,3 which gives an average of 4.5
        Bethy has marks of 6,5,5,3 which gives an average of 4.75

    For those students, the GetScholarshipCandidates method shall return the collection of Students, with Cathy and Bethy in it.

    If a student has no marks at all, we assume their average mark is 0.
     */
    public class WhereExercise1
    {
        public IEnumerable<Student> GetScholarshipCandidates(IEnumerable<Student> students)
        {
            return students.Where(student => 
            { 
                var average = student.Marks.Any() ? student.Marks.Average() : 0;
                return average > 4.6;
            });
        }
    }
}
