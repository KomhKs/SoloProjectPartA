using SoloProjectPartA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Application
{
    public class Print
    {
        public static void PrintAllStudents(Student stu)
        {
            Console.WriteLine($"{stu.StudentId,-15}{stu.FirstName,-25}{stu.LastName,-25}{stu.DateOfBirth.ToString("yyyy/MM/dd"),-25}{stu.TuitionFees}");
        }
        public static void PrintStudent(Student stu)
        {
            Console.WriteLine($"{stu.StudentId,-15}{stu.FirstName,-25}{stu.LastName,-25}");
        }
        public static void PrintAllTrainers(Trainer tr)
        {
            Console.WriteLine($"{tr.TrainerId,-15}{tr.FirstName,-25}{tr.LastName,-25}{tr.Subject}");
        }
        public static void PrintTrainer(Trainer tr)
        {
            Console.WriteLine($"{tr.TrainerId,-15}{tr.FirstName,-25}{tr.LastName,-25}");
        }
        public static void PrintAllCourses(Course cou)
        {
            Console.WriteLine($"{cou.CourseId,-15}{cou.Title,-25}{cou.Stream,-30}{cou.Type,-25}{cou.StartDate.ToString("yyyy/MM/dd"),-15}{cou.EndDate.ToString("yyyy/MM/dd")}");
        }
        public static void PrintCourse(Course cou)
        {
            Console.WriteLine($"{cou.CourseId,-30}{cou.Title,-25}{cou.Type,-25}");
        }
        public static void PrintAllAssignments(Assignment ass)
        {
            Console.WriteLine($"{ass.AssignmentId,-15}{ass.Title,-25}{ass.Description,-25}{ass.SubDate.ToString("yyyy/MM/dd"),-25}{ass.OralMark,-25}{ass.TotalMark}");
        }
        public static void PrintAssignment(Assignment ass)
        {
            Console.WriteLine($"{ass.AssignmentId,-15}{ass.Title,-25}");
        }
        public static void AllStudentsWithMultipleCourses(DbSet<Student> students, string message)
        {
            int c = 0;
            Console.WriteLine(message);
            foreach (var stu in students)
            {
                foreach (var cou in stu.Courses)
                {
                    c++;
                }
                if (c >= 1)
                {
                    PrintStudent(stu);
                }
            }
            if (c == 0)
            {
                Console.WriteLine("No Students With Multiple Courses In Database.");
            }
        }
    }
}
