using SoloProjectPartA.Database;
using SoloProjectPartA.Entities;
using SoloProjectPartA.Views;
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
            Course cou = AddCourseToStudentCreate(db);
            Assignment ass = AddAssignmentToStudentCreate(db);
            Student stu1 = new Student(name, surname, result, tuitionFees, cou, ass);
            db.Students.AddOrUpdate(stu1);
            db.SaveChanges();
        }
        public static void AddTrainer(MyApplicationDbContext db)
        {
            Input.ReadTrainer(out string name, out string surname, out string subject);
            Course cou = AddCourseToTrainerCreate(db);
            Trainer tr1 = new Trainer(name, surname, subject, cou);
            db.Trainers.AddOrUpdate(tr1);
            db.SaveChanges();
        }
        public static void AddCourse(MyApplicationDbContext db)
        {
            Input.ReadCourse(out string title, out string type, out string stream, out string startDate, out string endDate);
            DateTime result1;
            DateTime.TryParse(startDate, out result1);
            DateTime result2;
            DateTime.TryParse(endDate, out result2);
            Course cou1 = new Course(title, stream, type, result1, result2);
            db.Courses.AddOrUpdate(cou1);
            db.SaveChanges();
        }
        public static void AddAssignment(MyApplicationDbContext db)
        {
            Input.ReadAssignment(out string title, out string description, out string subDate, out float oralMark, out float totalMark);
            DateTime result;
            DateTime.TryParse(subDate, out result);
            Assignment ass1 = new Assignment(title, description, result, oralMark, totalMark);
            db.Assignments.AddOrUpdate(ass1);
            db.SaveChanges();
        }
        //public static void StudentsWithMultipleCourses(db.Students)
        public static void AddMultipleStudents(MyApplicationDbContext db)
        {
            string exit;
            do
            {
                AddStudent(db);
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "Y" && exit != "y");
        }
        public static void AddMultipleTrainers(MyApplicationDbContext db)
        {
            string exit;
            do
            {
                AddTrainer(db);
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "Y" && exit != "y");
        }
        public static void AddMultipleCourses(MyApplicationDbContext db)
        {
            string exit;
            do
            {
                Input.ReadCourse(out string title, out string type, out string stream, out string startDate, out string endDate);
                DateTime result1;
                DateTime.TryParse(startDate, out result1);
                DateTime result2;
                DateTime.TryParse(endDate, out result2);
                Course cou1 = new Course(title, stream, type, result1, result2);
                db.Courses.AddOrUpdate(cou1);
                db.SaveChanges();
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "Y" && exit != "y");
        }
        public static void AddMultipleAssignments(MyApplicationDbContext db)
        {
            string exit;
            do
            {
                Input.ReadAssignment(out string title, out string description, out string subDate, out float oralMark, out float totalMark);
                DateTime result;
                DateTime.TryParse(subDate, out result);
                Assignment ass1 = new Assignment(title, description, result, oralMark, totalMark);
                db.Assignments.AddOrUpdate(ass1);
                db.SaveChanges();
                Console.WriteLine("Exit Y/N");
                exit = Console.ReadLine();
            } while (exit != "Y" && exit != "y");
        }
        public static Course AddCourseToStudentCreate(MyApplicationDbContext db)
        {
            Console.WriteLine("Choose a Course Id");
            View.ShowAllCourses(db.Courses.ToList());
            int choice = Convert.ToInt16(Console.ReadLine());
            foreach (Course course in db.Courses)
            {
                if (course.CourseId == choice)
                {
                    return course;
                }
            }
            return null;
        }
        public static Assignment AddAssignmentToStudentCreate(MyApplicationDbContext db)
        {
            View.ShowAllAssignments(db.Assignments.ToList());
            Console.WriteLine("Choose an Assignment Id");
            int choice = Convert.ToInt16(Console.ReadLine());
            foreach (Assignment assignment in db.Assignments)
            {
                if (assignment.AssignmentId == choice)
                {
                    return assignment;
                }
            }
            return null;
        }
        public static void AddAssignmentToStudent(MyApplicationDbContext db)
        {
            View.ShowAllStudents(db.Students.Include(x => x.Assignments).ToList());
            Console.WriteLine("Choose Student Id to Add Assignment");
            int choiceStu = Convert.ToInt16(Console.ReadLine());
            Student stu1 = null;
            foreach (var stu in db.Students)
            {
                if (stu.StudentId == choiceStu)
                {
                    stu1 = stu;
                }
            }
            Assignment ass1 = AddAssignmentToStudentCreate(db);
            foreach (var ass in stu1.Assignments)
            {
                if (ass.AssignmentId == ass1.AssignmentId)
                {
                    Console.WriteLine($"Student {stu1.FirstName} with id = {stu1.StudentId} already has selected Assignment {ass1.Title} with id = {ass1.AssignmentId}");
                }
            }
            stu1.Assignments.Add(ass1);
            db.SaveChanges();
        }
        public static void AddCourseToStudent(MyApplicationDbContext db)
        {
            View.ShowAllStudents(db.Students.Include(x => x.Courses).ToList());
            Console.WriteLine("Choose Student Id to Add Course");
            int choiceStu = Convert.ToInt16(Console.ReadLine());
            Student stu1 = null;
            foreach (var stu in db.Students)
            {
                if (stu.StudentId == choiceStu)
                {
                    stu1 = stu;
                }
            }
            Course cou1 = AddCourseToStudentCreate(db);
            foreach (var cou in stu1.Courses)
            {
                if (cou.CourseId == cou1.CourseId)
                {
                    Console.WriteLine($"Student {stu1.FirstName} with id = {stu1.StudentId} already has selected Course {cou1.Title} with id = {cou1.CourseId}");
                }
            }
            stu1.Courses.Add(cou1);
            db.SaveChanges();
        }
        public static Course AddCourseToTrainerCreate(MyApplicationDbContext db)
        {
            Console.WriteLine("Choose a Course Id");
            View.ShowAllCourses(db.Courses.ToList());
            int choice = Convert.ToInt16(Console.ReadLine());
            foreach (Course course in db.Courses)
            {
                if (course.CourseId == choice)
                {
                    return course;
                }
            }
            return null;
        }
        public static void AddCourseToTrainer(MyApplicationDbContext db)
        {
            View.ShowAllTrainers(db.Trainers.Include(x => x.Courses).ToList());
            Console.WriteLine("Choose Trainer Id to Add Course");
            int choiceStu = Convert.ToInt16(Console.ReadLine());
            Trainer tra1 = null;
            foreach (var tra in db.Trainers)
            {
                if (tra.TrainerId == choiceStu)
                {
                    tra1 = tra;
                }
            }
            Course cou1 = AddCourseToTrainerCreate(db);
            foreach (var cou in tra1.Courses)
            {
                if (cou.CourseId == cou1.CourseId)
                {
                    Console.WriteLine($"Trainer {tra1.FirstName} with id = {tra1.TrainerId} already has selected Course {cou1.Title} with id = {cou1.CourseId}");
                }
            }
            tra1.Courses.Add(cou1);
            db.SaveChanges();
        }
    }
}


