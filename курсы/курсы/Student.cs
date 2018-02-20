using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсы
{
    public class Student
    {
        public string Namestudent { get; set; }
        public int Ocenko { get; set; }
        public string Namecoursestudent { get; set; }

        public Course Curse { get; set; }

        public void Setcoursestudent(Course course)
        {
            Namecoursestudent = course.Namecourse;
        }

    }
}
