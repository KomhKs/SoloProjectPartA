using SoloProjectPartA.Database;
using SoloProjectPartA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Application
{
    public class AddThings
    {
        public static void AddStudent(MyApplicationDbContext db)
        {
            Input.ReadStudent(out string name, out string surname, out decimal tuitionFees, out string dateOfBirth);
            DateTime result;
            DateTime.TryParse(dateOfBirth, out result);
            Student stu1 = new Student(name, surname, result, tuitionFees);
            db.Students.AddOrUpdate(stu1);
            db.SaveChanges();
        }
        public static void AddTrainer(MyApplicationDbContext db)
        {
            Input.ReadTrainer(out int id, out string name, out string surname, out string subject);
            Trainer tr1 = new Trainer(id, name, surname, subject);
            db.Trainers.AddOrUpdate(tr1);
            db.SaveChanges();
        }
        public static void AddCourse(MyApplicationDbContext db)
        {
            Input.ReadCourse(out int id, out string title, out string type, out string stream, out string startDate, out string endDate);
            DateTime result1;
            DateTime.TryParse(startDate, out result1);
            DateTime result2;
            DateTime.TryParse(endDate, out result2);
            Course cou1 = new Course(id, title, stream, type, result1, result2);
            db.Courses.AddOrUpdate(cou1);
            db.SaveChanges();
        }
        public static void AddAssignment(MyApplicationDbContext db)
        {
            Input.ReadAssignment(out int id, out string title, out string description, out string subDate, out float oralMark, out float totalMark);
            DateTime result;
            DateTime.TryParse(subDate, out result);
            Assignment ass1 = new Assignment(id, title, description, result, oralMark, totalMark);
            db.Assignments.AddOrUpdate(ass1);
            db.SaveChanges();
        }
        //public static void StudentsWithMultipleCourses(db.Students)
        public static void AddMultipleStudents(MyApplicationDbContext db)
        {
            string exit;
            do
            {
                Input.ReadStudent(out string name, out string surname, out decimal tuitionFees, out string dateOfBirth);
                DateTime result;
                DateTime.TryParse(dateOfBirth, out result);
                Student stu1 = new Student(name, surname, result, tuitionFees);
                db.Students.AddOrUpdate(stu1);
                db.SaveChanges();
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "N");
        }
        public static void AddMultipleTrainers(MyApplicationDbContext db)
        {
            string exit;
            do
            {
                Input.ReadTrainer(out int id, out string name, out string surname, out string subject);
                Trainer tr1 = new Trainer(id, name, surname, subject);
                db.Trainers.AddOrUpdate(tr1);
                db.SaveChanges();
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "N");
        }
        public static void AddMultipleCourses(MyApplicationDbContext db)
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
                db.Courses.AddOrUpdate(cou1);
                db.SaveChanges();
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "N");
        }
        public static void AddMultipleAssignments(MyApplicationDbContext db)
        {
            string exit;
            do
            {
                Input.ReadAssignment(out int id, out string title, out string description, out string subDate, out float oralMark, out float totalMark);
                DateTime result;
                DateTime.TryParse(subDate, out result);
                Assignment ass1 = new Assignment(id, title, description, result, oralMark, totalMark);
                db.Assignments.AddOrUpdate(ass1);
                db.SaveChanges();
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "N");
        }
    }

}

