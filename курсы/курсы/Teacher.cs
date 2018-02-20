using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсы
{
     public class Teacher
    {
        public string Name { get; set; }
        public string Namecourseteacher { get; set; }
        public string Teachercode { get; set; }

        public Student[] Students { get; set; }
        public Course Curse { get; set; }

        

        public void Setcourseteacher(Course course)
        {
            Namecourseteacher = course.Namecourse;
        } 
        public int Ocenka(Student students, Teacher teach)
        {
            if(teach.Namecourseteacher == students.Namecoursestudent)
            {
                Console.WriteLine("ведите оценку");
                students.Ocenko = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Невозможно поставить оценкy");
            }
            return students.Ocenko;
        }
    }
}
