using SoloProjectPartA.Database;
using SoloProjectPartA.Enums;
using SoloProjectPartA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Application
{
    public class Controller
    {
        public static void Controller1(MyDatabase db, SelectMenu selection)
        {
            switch (selection)
            {
                case SelectMenu.AddStudent: AddThings.AddStudent(db.Students, db); break;
                case SelectMenu.AddMultipleStudents: AddThings.AddMultipleStudents(db.Students, db); break;
                case SelectMenu.ShowAllStudents: View.ShowAllStudents(db.Students, "- - - - - - - - - - - - - - - - Showing All Students - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllStudentsPerCourse: View.StudentsPerCourse(db.Students, "- - - - - - - - - - - - - - - - Showing Students Per Course - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.StudentsWithMultipleCourses: Print.AllStudentsWithMultipleCourses(db.Students, "- - - - - - - - - - - - - - - - Showing Students With Myltiple Courses - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.AddCourse: AddThings.AddCourse(db.Courses, db); break;
                case SelectMenu.AddMultipleCourses: AddThings.AddMultipleCourses(db.Courses, db); break;
                case SelectMenu.ShowAllCourses: View.ShowAllCourses(db.Courses, "- - - - - - - - - - - - - - - - Showing All Courses - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.AddTrainer: AddThings.AddTrainer(db.Trainers, db); break;
                case SelectMenu.AddMultipleTrainers: AddThings.AddMultipleTrainers(db.Trainers, db); break;
                case SelectMenu.ShowAllTrainers: View.ShowAllTrainers(db.Trainers, "- - - - - - - - - - - - - - - - Showing All Trainers - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllTrainersPerCourse: View.TrainersPerCourse(db.Trainers, "- - - - - - - - - - - - - - - - Showing Trainers Per Course - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.AddAssignment: AddThings.AddAssignment(db.Assignments, db); break;
                case SelectMenu.AddMultipleAssignments: AddThings.AddMultipleAssignments(db.Assignments, db); break;
                case SelectMenu.ShowAllAssignments: View.ShowAllAssignments(db.Assignments, "- - - - - - - - - - - - - - - - Showing All Assignments - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllAssignmentsPerCourse: View.AssignmentsPerCourse(db.Assignments, "- - - - - - - - - - - - - - - - Showing Assignments Per Course - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllAssignmentsPerStudent: View.AssignmentsPerStudent(db.Assignments, "- - - - - - - - - - - - - - - - Showing Assignments Per Student - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ExitApplication: Console.WriteLine("Exiting Application"); break;
                default: Console.WriteLine("I Am Error!"); break;
            }
        }
    }
}
