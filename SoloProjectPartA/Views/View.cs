using SoloProjectPartA.Application;
using SoloProjectPartA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Views
{
    public class View
    {
        public static void ShowAllStudents(List<Student> students, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"{"Student Id",-15}{"FirstName",-25}{"LastName",-25}{"DateOfBirth",-25}{"TuitionFees"}");
            foreach (var stu in students)
            {
                Print.PrintAllStudents(stu);
            }
        }
        public static void ShowAllTrainers(List<Trainer> trainers, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"{"Trainer Id",-15}{"FirstName",-25}{"LastName",-25}{"Subject",-25}");
            foreach (var tr in trainers)
            {
                Print.PrintAllTrainers(tr);
            }
        }
        public static void ShowAllCourses(List<Course> courses, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"{"Course Id",-15}{"Title",-25}{"Stream",-30}{"Type",-25}{"StartDate",-15}{"EndDate"}");
            foreach (var cou in courses)
            {
                Print.PrintAllCourses(cou);
            }
        }
        public static void ShowAllAssignments(List<Assignment> assignments, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine($"{"Assignment Id",-15}{"Title",-25}{"Description",-25}{"SubDateTime",-25}{"OralMark",-25}{"TotalMark",-25}");
            foreach (var ass in assignments)
            {
                Print.PrintAllAssignments(ass);
            }
        }
        public static void StudentsPerCourse(List<Student> students, string message)
        {
            {
                Console.WriteLine(message);
                Console.WriteLine($"{"Student Id",-15}{"First Name",-15}{"Last Name",-15}");
                foreach (var stu in students)
                {
                    Print.PrintStudent(stu);
                    Console.WriteLine($"{"",-30}{"Course Id",-30}{"Title",-25}{"Type",-25}");
                    foreach (var cou in stu.Courses)
                    {
                        Console.Write($"{"",-30}");
                        Print.PrintCourse(cou);
                    }
                }
            }
        }
        public static void TrainersPerCourse(List<Trainer> trainers, string message)
        {
            {
                Console.WriteLine(message);
                Console.WriteLine($"{"Trainer Id",-15}{"First Name",-15}{"Last Name",-15}");
                foreach (var tr in trainers)
                {
                    Print.PrintTrainer(tr);
                    Console.WriteLine($"{"",-30}{"Course Id",-30}{"Title",-25}{"Type",-25}");
                    foreach (var cou in tr.Courses)
                    {
                        Console.Write($"{"",-30}");
                        Print.PrintCourse(cou);
                    }
                }
            }
        }
        public static void AssignmentsPerStudent(List<Assignment> assignments, string message)
        {
            {
                Console.WriteLine(message);
                Console.WriteLine($"{"Assignment Id",-15}{"Title",-15}");
                foreach (var ass in assignments)
                {
                    Print.PrintAssignment(ass);
                    Console.WriteLine($"{"",-30}{"Course Id",-30}{"Title",-25}{"Type",-25}");
                    foreach (var stu in ass.Students)
                    {
                        Console.Write($"{"",-30}");
                        Print.PrintStudent(stu);
                    }
                }
            }
        }
        public static void AssignmentsPerCourse(List<Assignment> assignments, string message)
        {
            {
                Console.WriteLine(message);
                Console.WriteLine($"{"Assignment Id",-15}{"Title",-15}");
                foreach (var ass in assignments)
                {
                    Print.PrintAssignment(ass);
                    Console.WriteLine($"{"",-30}{"Course Id",-30}{"Title",-25}{"Type",-25}");
                    foreach (var cou in ass.Courses)
                    {
                        Console.Write($"{"",-30}");
                        Print.PrintCourse(cou);
                    }
                }
            }
        }
        public static void ViewMenu()
        {
            const int first = -40;
            const int second = -40;
            const int third = -50;
            const int fourth = -40;
            Console.WriteLine("Choose an option");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine($"{"------- Students -------",first}{"------- Courses -------",second}{"------- Trainers -------",third}{"------- Assignments -------",fourth}{"------- 0 to EXIT -------"}");
            Console.WriteLine($"{"1 - Add Student",first}{"6 - Add Course",second}{"9 - Add Trainer",third}{"13 - Add Assignment",fourth}");
            Console.WriteLine($"{"2 - Add Multiple Students",first}{"7 - Add Multiple Courses",second}{"10 - Add Multiple Trainers",third}{"14 - Add Multiple Assignments",fourth}");
            Console.WriteLine($"{"3 - Show All Students",first}{"8 - Show All Courses",second}{"11 - Show All Trainers",third}{"15 - Show All Assignments",fourth}");
            Console.WriteLine($"{"4 - Show All Students Per Course",first}{"",second}{"12 - Show All Trainers Per Course",third}{"16 - Show All Assignments Per Course",fourth}");
            Console.WriteLine($"{"5 - Students With Multiple Courses",first}{"",second}{"",third}{"17 - Show All Assignments Per Student",fourth}");
        }
    }
}
