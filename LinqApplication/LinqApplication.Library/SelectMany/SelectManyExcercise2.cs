using LinqApplication.LinqApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqApplication.LinqApplication.Library.SelectMany
{
    public class SelectManyExcercise2
    {
        /*
         Imagine you work on a website of a school. On the top of the page, there is a "Hall of fame" panel, with the top 5 marks in the school together with the name of the student who earned this mark.

        Implement the BestMarksAndStudents method, which given a collection of students will return a collection of strings with the student's name and the mark. We want to select the top 5 marks in the entire school. Even if a single student has the 5 best marks in the whole school, she should occupy all 5 places in this list.

        Let's see an example. For the following students:
            Lucy has marks {3, 6, 2, 6}
            Tom has marks {4, 5}
            Alice has marks {3, 3, 5}
            Brian has marks {2, 3, 3}
        
        ...the result shall be:
           "Lucy: 6"
           "Lucy: 6"
           "Alice: 5"
           "Tom: 5"
           "Tom: 4"

        We order the result from the best mark to the worst. If two students have the same mark (in this case Alice and Tom have a mark of 5) we should sort them in alphabetical order by student's name.
         */
        public IEnumerable<string> BestMarksAndStudents(IEnumerable<Student> students)
        {
            return students.SelectMany(student => student.Marks, (student, mark) => 
                                       new { Student = student, Mark = mark })
                           .OrderByDescending(student => student.Mark)
                           .ThenBy(student => student.Student.Name)
                           .Take(5)
                           .Select(studentObj => $"{studentObj.Student.Name}: {studentObj.Mark}");

        }
    }
}
