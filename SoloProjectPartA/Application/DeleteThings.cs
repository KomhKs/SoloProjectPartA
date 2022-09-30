using SoloProjectPartA.Database;
using SoloProjectPartA.Entities;
using SoloProjectPartA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Application
{
    public class DeleteThings
    {
        public static void DeleteStudent(MyApplicationDbContext db, List<Student> students)
        {
            View.ShowAllStudents(db.Students.ToList());
            Student stu1;
            Console.WriteLine("Select Student Id to Delete Student");
            int choice = Convert.ToInt16(Console.ReadLine());
            foreach (Student stu in students)
            {
                if (stu.StudentId == choice)
                {
                    stu1 = stu;
                    db.Students.Remove(stu1);
                    db.SaveChanges();
                    DeleteCourseFromStudent(db, stu1);
                    DeleteAssignmentFromStudent(db, stu1);
                }
            }
        }
        public static void DeleteTrainer(MyApplicationDbContext db, List<Trainer> trainers)
        {
            View.ShowAllTrainers(db.Trainers.ToList());
            Trainer tra1;
            Console.WriteLine("Select Trainer Id to Delete Trainer");
            int choice = Convert.ToInt16(Console.ReadLine());
            foreach (Trainer tra in trainers)
            {
                if (tra.TrainerId == choice)
                {
                    tra1 = tra;
                    db.Trainers.Remove(tra1);
                    db.SaveChanges();
                    DeleteCourseFromTrainer(db, tra1);
                }
            }
        }
        public static void DeleteCourse(MyApplicationDbContext db, List<Course> courses)
        {
            View.ShowAllCourses(db.Courses.ToList());
            Course cou1;
            Console.WriteLine("Select Course Id to Delete Course");
            int choice = Convert.ToInt16(Console.ReadLine());
            foreach (Course cou in courses)
            {
                if (cou.CourseId == choice)
                {
                    cou1 = cou;
                    db.Courses.Remove(cou1);
                    db.SaveChanges();
                    DeleteStudentFromCourse(db, cou1);
                    DeleteTrainerFromCourse(db, cou1);
                    DeleteAssignmentFromCourse(db, cou1);
                }
            }
        }

        private static void DeleteAssignmentFromCourse(MyApplicationDbContext db, Course cou1)
        {
            foreach (Assignment assignment in db.Assignments)
            {
                foreach (Course course in assignment.Courses)
                {
                    if (course.CourseId == cou1.CourseId)
                    {
                        assignment.Courses.Remove(cou1);
                    }
                }
            }
            db.SaveChanges();
        }

        private static void DeleteTrainerFromCourse(MyApplicationDbContext db, Course cou1)
        {
            foreach (Trainer trainer in db.Trainers)
            {
                foreach (Course course in trainer.Courses)
                {
                    if (course.CourseId == cou1.CourseId)
                    {
                        trainer.Courses.Remove(cou1);
                    }
                }
            }
            db.SaveChanges();
        }

        private static void DeleteStudentFromCourse(MyApplicationDbContext db, Course cou1)
        {
            foreach (Student student in db.Students)
            {
                foreach (Course course in student.Courses)
                {
                    if (course.CourseId == cou1.CourseId)
                    {
                        student.Courses.Remove(cou1);
                    }
                }
            }
            db.SaveChanges();
        }

        public static void DeleteAssignment(MyApplicationDbContext db, List<Assignment> assignments)
        {
            View.ShowAllAssignments(db.Assignments.ToList());
            Assignment ass1;
            Console.WriteLine("Select Course Id to Delete Course");
            int choice = Convert.ToInt16(Console.ReadLine());
            foreach (Assignment ass in assignments)
            {
                if (ass.AssignmentId == choice)
                {
                    ass1 = ass;
                    db.Assignments.Remove(ass1);
                    db.SaveChanges();
                    DeleteStudentFromAssignment(db, ass1);
                }
            }
        }

        private static void DeleteStudentFromAssignment(MyApplicationDbContext db, Assignment ass1)
        {
            foreach (Student student in db.Students)
            {
                foreach (Assignment assignment in student.Assignments)
                {
                    if (assignment.AssignmentId == ass1.AssignmentId)
                    {
                        student.Assignments.Remove(ass1);
                    }
                }
            }
            db.SaveChanges();
        }

        public static void DeleteCourseFromStudent(MyApplicationDbContext db, Student stu)
        {
            foreach (Course course in stu.Courses)
            {
                foreach (Course cou in db.Courses)
                {
                    if (course.CourseId == cou.CourseId)
                    {
                        cou.Students.Remove(stu);
                    }
                }
            }
            db.SaveChanges();
        }
        public static void DeleteCourseFromTrainer(MyApplicationDbContext db, Trainer tra)
        {
            foreach (Course course in tra.Courses)
            {
                foreach (Course cou in db.Courses)
                {
                    if (course.CourseId == cou.CourseId)
                    {
                        cou.Trainers.Remove(tra);
                    }
                }
            }
            db.SaveChanges();
        }
        public static void DeleteAssignmentFromStudent(MyApplicationDbContext db, Student stu)
        {
            foreach (Assignment assignment in stu.Assignments)
            {
                foreach (Assignment ass in db.Assignments)
                {
                    if (assignment.AssignmentId == ass.AssignmentId)
                    {
                        ass.Students.Remove(stu);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}
