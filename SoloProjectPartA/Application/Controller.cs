﻿using SoloProjectPartA.Database;
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
                case SelectMenu.ShowAllStudents: View.ShowAllStudents(db.Students.ToList(), "- - - - - - - - - - - - - - - Showing All Students - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllStudentsPerCourse: View.StudentsPerCourse(db.Courses.Include(x => x.Students).ToList(), "- - - - - - - - - - - - - - - Showing Students Per Course - - - - - - - - - - - - - - -"); break;
                case SelectMenu.StudentsWithMultipleCourses: Print.AllStudentsWithMultipleCourses(db.Students.Include(x => x.Courses).ToList(), "- - - - - - - - - - - - - - - Showing Students With Myltiple Courses - - - - - - - - - - - - - - -"); break;
                case SelectMenu.AddCourse: AddThings.AddCourse(db); break;
                case SelectMenu.AddMultipleCourses: AddThings.AddMultipleCourses(db); break;
                case SelectMenu.ShowAllCourses: View.ShowAllCourses(db.Courses.ToList(), "- - - - - - - - - - - - - - - Showing All Courses - - - - - - - - - - - - - - -"); break;
                case SelectMenu.AddTrainer: AddThings.AddTrainer(db); break;
                case SelectMenu.AddMultipleTrainers: AddThings.AddMultipleTrainers(db); break;
                case SelectMenu.ShowAllTrainers: View.ShowAllTrainers(db.Trainers.ToList(), "- - - - - - - - - - - - - - - Showing All Trainers - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllTrainersPerCourse: View.TrainersPerCourse(db.Trainers.Include(x => x.Courses).ToList(), "- - - - - - - - - - - - - - - Showing Trainers Per Course - - - - - - - - - - - - - - - -"); break;
                case SelectMenu.AddAssignment: AddThings.AddAssignment(db); break;
                case SelectMenu.AddMultipleAssignments: AddThings.AddMultipleAssignments(db); break;
                case SelectMenu.ShowAllAssignments: View.ShowAllAssignments(db.Assignments.ToList(), "- - - - - - - - - - - - - - - Showing All Assignments - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllAssignmentsPerCourse: View.AssignmentsPerCourse(db.Courses.Include(x => x.Assignments).ToList(), "- - - - - - - - - - - - - - Showing Assignments Per Course - - - - - - - - - - - - - - -"); break;
                case SelectMenu.ShowAllAssignmentsPerStudent: View.AssignmentsPerStudent(db.Students.Include(x => x.Assignments).ToList(), "- - - - - - - - - - - - - - Showing Assignments Per Student - - - - - - - - - - - - - - -"); break;
                case SelectMenu.AddCoursetoStudent: AddThings.AddCourseToStudent(db); break;
                case SelectMenu.AddAssignmentToStudent: AddThings.AddAssignmentToStudent(db); break;
                case SelectMenu.AddCourseToTrainer: AddThings.AddCourseToTrainer(db); break;
                case SelectMenu.DeleteThings: Controller.DeleteControler(db); break;
                case SelectMenu.ExitApplication: Console.WriteLine("Exiting Application"); break;
                default: Console.WriteLine("I Am Error!"); break;
            }
        }
        public static void DeleteControler(MyApplicationDbContext db)
        {
            int inputNumeric;
            bool invalidInput;
            DeleteMenu selection;
            do
            {
                View.DeleteMenu();
                string inputString = Console.ReadLine();
                bool isNumeric = int.TryParse(inputString, out _);
                while (!isNumeric)
                {
                    Console.Clear();
                    Console.WriteLine("I Am Error! Enter Numeric Input.");
                    View.ViewMenu();
                    inputString = Console.ReadLine();
                    isNumeric = int.TryParse(inputString, out _);
                }
                inputNumeric = Convert.ToInt32(inputString);
                invalidInput = inputNumeric < 0 && inputNumeric > 4;
                while (invalidInput)
                {
                    Console.WriteLine("I Am Error! Enter Input Within the Appropriate Range.");
                    inputNumeric = Convert.ToInt32(inputString);
                    invalidInput = inputNumeric < 0 && inputNumeric > 4;
                }
                Console.Clear();
                selection = (DeleteMenu)inputNumeric;
                switch (selection)
                {
                    case DeleteMenu.Exit:
                        Console.WriteLine("Returning to Start Menu");
                        break;
                    case DeleteMenu.DeleteStudent:
                        Console.WriteLine("Under Construction");
                        break;
                    case DeleteMenu.DeleteTrainer:
                        Console.WriteLine("Under Construction");
                        break;
                    case DeleteMenu.DeleteCourse:
                        Console.WriteLine("Under Construction");
                        break;
                    case DeleteMenu.DeleteAssignment:
                        Console.WriteLine("Under Construction");
                        break;
                    default: Console.WriteLine("I Am Error!"); break;
                }
            } while (selection != 0);
        }
    }
}
