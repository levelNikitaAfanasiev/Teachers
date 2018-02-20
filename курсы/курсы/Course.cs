using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсы
{
     public class Course
    {
        public Teacher Teache { get; set; }
        public Student[] Students { get; set; }
        public string Namecourse { get; set; }
        public string Courseteacher { get; set; }
        public void Setstudents(Student[] students)
        {
            if (students.Length > 5)

                return;
            Students = students;


        }
        public void Showstudents(Student[] students, Course course)
        {
         
            for (int i = 0; i < 10; i++)
            {
               
                if(course.Namecourse == students[i].Namecoursestudent)
                Console.WriteLine("student {0}", students[i].Namestudent);
              
            }
        }
        public void Showteacher(Teacher teach, Course course)
        {
          
                Console.WriteLine("Course {0}  Teacher {1}  ", course.Namecourse, teach.Name);
   
            
        }
        public void Showstudentsanduspevaemost(Student[] students, Course course)
        {
            for(int i = 0; i < 10; i++)
            {
                if (course.Namecourse == students[i].Namecoursestudent)
                {
                    Console.WriteLine("student {0}", students[i].Namestudent); ;
                    Console.WriteLine("ocenka {0}", students[i].Ocenko);
                }
            }
        }
    }
}
