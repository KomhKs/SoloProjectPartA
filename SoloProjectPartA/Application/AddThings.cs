using SoloProjectPartA.Database;
using SoloProjectPartA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Application
{
    public class AddThings
    {
        public static void AddStudent(List<Student> students, MyDatabase db)
        {
            Input.ReadStudent(out int id, out string name, out string surname, out decimal tuitionFees, out string dateOfBirth);
            DateTime result;
            DateTime.TryParse(dateOfBirth, out result);
            Student stu1 = new Student(id, name, surname, result, tuitionFees);
            db.Students.Add(stu1);
        }
        public static void AddTrainer(List<Trainer> trainers, MyDatabase db)
        {
            Input.ReadTrainer(out int id, out string name, out string surname, out string subject);
            Trainer tr1 = new Trainer(id, name, surname, subject);
            db.Trainers.Add(tr1);
        }
        public static void AddCourse(List<Course> courses, MyDatabase db)
        {
            Input.ReadCourse(out int id, out string title, out string type, out string stream, out string startDate, out string endDate);
            DateTime result1;
            DateTime.TryParse(startDate, out result1);
            DateTime result2;
            DateTime.TryParse(endDate, out result2);
            Course cou1 = new Course(id, title, stream, type, result1, result2);
            db.Courses.Add(cou1);
        }
        public static void AddAssignment(List<Assignment> assignments, MyDatabase db)
        {
            Input.ReadAssignment(out int id, out string title, out string description, out string subDate, out float oralMark, out float totalMark);
            DateTime result;
            DateTime.TryParse(subDate, out result);
            Assignment ass1 = new Assignment(id, title, description, result, oralMark, totalMark);
            db.Assignments.Add(ass1);
        }
        //public static void StudentsWithMultipleCourses(db.Students)
        public static void AddMultipleStudents(List<Student> students, MyDatabase db)
        {
            string exit;
            do
            {
                Input.ReadStudent(out int id, out string name, out string surname, out decimal tuitionFees, out string dateOfBirth);
                DateTime result;
                DateTime.TryParse(dateOfBirth, out result);
                Student stu1 = new Student(id, name, surname, result, tuitionFees);
                db.Students.Add(stu1);
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "N");
        }
        public static void AddMultipleTrainers(List<Trainer> trainers, MyDatabase db)
        {
            string exit;
            do
            {
                Input.ReadTrainer(out int id, out string name, out string surname, out string subject);
                Trainer tr1 = new Trainer(id, name, surname, subject);
                db.Trainers.Add(tr1);
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "N");
        }
        public static void AddMultipleCourses(List<Course> courses, MyDatabase db)
        {
            string exit;
            do
            {
                Input.ReadCourse(out int id, out string title, out string type, out string stream, out string startDate, out string endDate);
                DateTime result1;
                DateTime.TryParse(startDate, out result1);
                DateTime result2;
                DateTime.TryParse(endDate, out result2);
                Course cou1 = new Course(id, title, stream, type, result1, result2);
                db.Courses.Add(cou1);
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "N");
        }
        public static void AddMultipleAssignments(List<Assignment> assignments, MyDatabase db)
        {
            string exit;
            do
            {
                Input.ReadAssignment(out int id, out string title, out string description, out string subDate, out float oralMark, out float totalMark);
                DateTime result;
                DateTime.TryParse(subDate, out result);
                Assignment ass1 = new Assignment(id, title, description, result, oralMark, totalMark);
                db.Assignments.Add(ass1);
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "N");
        }
    }

}

