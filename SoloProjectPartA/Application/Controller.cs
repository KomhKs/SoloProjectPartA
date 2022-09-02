using SoloProjectPartA.Database;
using SoloProjectPartA.Enums;
using SoloProjectPartA.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Application
{
    public class Controller
    {
        public static void Controller1(MyApplicationDbContext db, SelectMenu selection)
        {
            switch (selection)
            {
                case SelectMenu.AddStudent: AddThings.AddStudent(db); break;
                case SelectMenu.AddMultipleStudents: AddThings.AddMultipleStudents(db); break;
                case SelectMenu.ShowAllStudents: View.ShowAllStudents(db.Students, "- - - - - - - - - - - - - - - - Showing All Students - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllStudentsPerCourse: View.StudentsPerCourse(db.Students.Include(x => x.Courses).Include(x => x.Assignments).ToList(), "- - - - - - - - - - - - - - - - Showing Students Per Course - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.StudentsWithMultipleCourses: Print.AllStudentsWithMultipleCourses(db.Students.Include(x => x.Courses).Include(x => x.Assignments).ToList(), "- - - - - - - - - - - - - - - - Showing Students With Myltiple Courses - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.AddCourse: AddThings.AddCourse(db); break;
                case SelectMenu.AddMultipleCourses: AddThings.AddMultipleCourses(db); break;
                case SelectMenu.ShowAllCourses: View.ShowAllCourses(db.Courses, "- - - - - - - - - - - - - - - - Showing All Courses - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.AddTrainer: AddThings.AddTrainer(db); break;
                case SelectMenu.AddMultipleTrainers: AddThings.AddMultipleTrainers(db); break;
                case SelectMenu.ShowAllTrainers: View.ShowAllTrainers(db.Trainers, "- - - - - - - - - - - - - - - - Showing All Trainers - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllTrainersPerCourse: View.TrainersPerCourse(db.Trainers.Include(x => x.Courses).ToList(), "- - - - - - - - - - - - - - - - Showing Trainers Per Course - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.AddAssignment: AddThings.AddAssignment(db); break;
                case SelectMenu.AddMultipleAssignments: AddThings.AddMultipleAssignments(db); break;
                case SelectMenu.ShowAllAssignments: View.ShowAllAssignments(db.Assignments, "- - - - - - - - - - - - - - - - Showing All Assignments - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllAssignmentsPerCourse: View.AssignmentsPerCourse(db.Assignments.Include(x => x.Courses).ToList(), "- - - - - - - - - - - - - - - - Showing Assignments Per Course - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllAssignmentsPerStudent: View.AssignmentsPerStudent(db.Assignments.Include(x => x.Courses).ToList(), "- - - - - - - - - - - - - - - - Showing Assignments Per Student - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ExitApplication: Console.WriteLine("Exiting Application"); break;
                default: Console.WriteLine("I Am Error!"); break;
            }
        }
    }
}
