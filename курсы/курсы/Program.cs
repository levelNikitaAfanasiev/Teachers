using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсы
{
    class Program
    {
        static void Main(string[] args)
        {
            Course[] course = new Course[2];
            Teacher[] teacher = new Teacher[2];
            Student[] student = new Student[10];
            
            for(int i = 0; i < 2; i++)
            {
                course[i] = new Course();
                teacher[i] = new Teacher();
            }

            course[0].Namecourse = "C#.Net";
            course[1].Namecourse = "Java";
            teacher[0].Name = "Jason";
            teacher[0].Teachercode = "1";
            teacher[1].Name = "Mike";
            teacher[1].Teachercode = "2";
            teacher[0].Setcourseteacher(course[0]);
            teacher[1].Setcourseteacher(course[1]);
            for(int i = 0; i < 5; i++)
            {
                student[i] = new Student();
                Console.WriteLine("введите имя студента C#.Net");
                student[i].Namestudent = Console.ReadLine();
                student[i].Setcoursestudent(course[0]);
               
               
            }
               for(int i = 5; i < 10; i++)
            {
                student[i] = new Student();
                Console.WriteLine("введите имя студента Java");
                student[i].Namestudent = Console.ReadLine();
                student[i].Setcoursestudent(course[1]);
                
            }
            for (int i = 0; i < 2; i++)
                course[i].Showteacher(teacher[i], course[i]);
            Console.WriteLine("введите ваш код если вы преподователь");
            string teachercode = Console.ReadLine();
            if (teacher[0].Teachercode == teachercode)
                for (int i = 0; i < 5; i++)
                    teacher[0].Ocenka(student[i], teacher[0]);
            if (teacher[1].Teachercode == teachercode)
                for (int i = 0; i < 5; i++)
                    teacher[1].Ocenka(student[i], teacher[1]);
            else
            Console.WriteLine("Error");
            Console.WriteLine("C# students");
          
            course[0].Showstudentsanduspevaemost(student,course[0]);
            Console.WriteLine("Java students");
            course[1].Showstudentsanduspevaemost(student, course[1]);

              
        }
    }
}
