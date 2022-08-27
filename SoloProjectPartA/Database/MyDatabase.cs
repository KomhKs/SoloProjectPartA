using SoloProjectPartA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Database
{
    public class MyDatabase
    {
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Student> Students { get; set; } = new List<Student>();
        public MyDatabase()
        {
            #region Seeding Students
            Student s1 = new Student(1, "Kostas", "Mpaladimas", new DateTime(1984, 05, 16), 2500);
            Student s2 = new Student(2, "Giorgos", "Dimoylas", new DateTime(1954, 06, 17), 2250);
            Student s3 = new Student(3, "Alexandros", "Poylopoylos", new DateTime(1994, 07, 18), 2250);
            Student s4 = new Student(4, "Sotiris", "Xabales", new DateTime(1992, 08, 19), 2500);
            Student s5 = new Student(5, "Nikos", "Kollaros", new DateTime(1997, 08, 20), 2250);
            Student s6 = new Student(6, "Stayros", "Sionis", new DateTime(1987, 09, 21), 2500);
            Student s7 = new Student(7, "Stathis", "Karachalios", new DateTime(1986, 10, 22), 2250);
            Student s8 = new Student(8, "Tasos", "Student Last Name 8", new DateTime(2001, 11, 23), 2500);
            Student s9 = new Student(9, "Giannis", "Galanakis", new DateTime(2000, 12, 24), 2500);
            Student s10 = new Student(10, "Aris", "Karagiannis", new DateTime(1984, 01, 25), 2500);
            Student s11 = new Student(11, "Alkis", "Pagoulatos", new DateTime(1985, 02, 26), 2250);
            Student s12 = new Student(12, "Theodoros", "Sioylas", new DateTime(1987, 01, 16), 2500);
            Student s13 = new Student(13, "Nikolaos", "Polemarchakis", new DateTime(1986, 03, 27), 2250);
            #endregion
            #region Seeding Trainers
            Trainer t1 = new Trainer(1, "Ektoras", "Gatsos", "C#");
            Trainer t2 = new Trainer(2, "Nikolaos", "Polizos", "Power Electronics");
            Trainer t3 = new Trainer(3, "Georgios", "Drakakis", "Theory of electrical circuits");
            Trainer t4 = new Trainer(4, "Ioannis", "Siderakis", "High Voltages");
            Trainer t5 = new Trainer(5, "Aristedes", "Kyprakis", "Biomechanical Automations");
            Trainer t6 = new Trainer(6, "Mixalis", "Sfakiotakis", "Systems of Automated Control");
            Trainer t7 = new Trainer(7, "Dimitrios", "Minadakis", "Microcontrolers");
            #endregion
            #region Seeding Assignments
            Assignment a1 = new Assignment(1, "Assignment 1", "Description 1", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a1.Students = new List<Student> { s1, s3, s5 };
            s1.Assignment.Add(a1);
            s3.Assignment.Add(a1);
            s5.Assignment.Add(a1);

            Assignment a2 = new Assignment(2, "Assignment 2", "Description 2", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to 
            a2.Students = new List<Student> { s2, s4, s6, s7 };
            s2.Assignment.Add(a2);
            s4.Assignment.Add(a2);
            s6.Assignment.Add(a2);
            s7.Assignment.Add(a2);

            Assignment a3 = new Assignment(3, "Assignment 3", "Description 3", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a3.Students = new List<Student> { s2, s3, s5, s7, s8, s10 };
            s2.Assignment.Add(a3);
            s3.Assignment.Add(a3);
            s5.Assignment.Add(a3);
            s7.Assignment.Add(a3);
            s8.Assignment.Add(a3);
            s10.Assignment.Add(a3);

            Assignment a4 = new Assignment(4, "Assignment 4", "Description 4", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a4.Students = new List<Student> { s1, s11 };
            s1.Assignment.Add(a1);
            s11.Assignment.Add(a4);

            Assignment a5 = new Assignment(5, "Assignment 5", "Description 5", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a5.Students = new List<Student> { s3, s6, s9, s11 };
            s3.Assignment.Add(a5);
            s6.Assignment.Add(a5);
            s9.Assignment.Add(a5);
            s11.Assignment.Add(a5);

            Assignment a6 = new Assignment(6, "Assignment 6", "Description 6", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a6.Students = new List<Student> { s1, s2, s3, s4, s5 };
            s1.Assignment.Add(a6);
            s2.Assignment.Add(a6);
            s3.Assignment.Add(a6);
            s4.Assignment.Add(a6);
            s5.Assignment.Add(a6);

            Assignment a7 = new Assignment(7, "Assignment 7", "Description 7", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a7.Students = new List<Student> { s6, s7, s8, s9 };
            s6.Assignment.Add(a7);
            s7.Assignment.Add(a7);
            s8.Assignment.Add(a7);
            s9.Assignment.Add(a7);

            Assignment a8 = new Assignment(8, "Assignment 8", "Description 8", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a8.Students = new List<Student> { s10, s11 };
            s10.Assignment.Add(a8);
            s11.Assignment.Add(a8);

            Assignment a9 = new Assignment(9, "Assignment 9", "Description 9", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a9.Students = new List<Student> { s5, s7, s9, s11 };
            s5.Assignment.Add(a9);
            s7.Assignment.Add(a9);
            s9.Assignment.Add(a9);
            s11.Assignment.Add(a9);

            Assignment a10 = new Assignment(10, "Assignment 10", "Description 10", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a10.Students = new List<Student> { s1, s6, s9, s10, s11 };
            s1.Assignment.Add(a10);
            s6.Assignment.Add(a10);
            s9.Assignment.Add(a10);
            s10.Assignment.Add(a10);
            s11.Assignment.Add(a10);

            Assignment a11 = new Assignment(11, "Assignment 11", "Description 11", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a11.Students = new List<Student> { s3, s4, s6, s7, s10 };
            s3.Assignment.Add(a11);
            s4.Assignment.Add(a11);
            s6.Assignment.Add(a11);
            s7.Assignment.Add(a11);
            s10.Assignment.Add(a11);
            #endregion
            #region Seeding Courses
            Course c1 = new Course(1, "Course 1", "What the f is Stream? 1", "Part-Time", new DateTime(2022, 03, 01), new DateTime(2022, 08, 31));
            // Adding Students to Courses
            c1.Students = new List<Student>() { s1, s3, s12 };
            s1.Courses.Add(c1);
            s3.Courses.Add(c1);
            s12.Courses.Add(c1);

            // Adding Assignments to Courses
            c1.Assignments = new List<Assignment>() { a2, a3, a5, a7, a11 };
            a2.Courses.Add(c1);
            a3.Courses.Add(c1);
            a5.Courses.Add(c1);
            a7.Courses.Add(c1);
            a11.Courses.Add(c1);

            // Adding Trainers to Courses
            c1.Trainers = new List<Trainer>() { t1, t4, t6 };
            t1.Courses.Add(c1);
            t4.Courses.Add(c1);
            t6.Courses.Add(c1);

            Course c2 = new Course(2, "Course 2", "What the f is Stream? 2", "Full-Time", new DateTime(2022, 03, 01), new DateTime(2022, 05, 31));
            // Adding Students to Courses
            c2.Students = new List<Student>() { s2, s4, s5 };
            s2.Courses.Add(c2);
            s4.Courses.Add(c2);
            s5.Courses.Add(c2);

            // Adding Assignments to Courses
            c2.Assignments = new List<Assignment>() { a1, a3 };
            a1.Courses.Add(c2);
            a3.Courses.Add(c2);

            // Adding Trainers to Courses
            c2.Trainers = new List<Trainer>() { t2, t3, t5, t7 };
            t2.Courses.Add(c2);
            t3.Courses.Add(c2);
            t5.Courses.Add(c2);
            t7.Courses.Add(c2);

            Course c3 = new Course(3, "Course 3", "What the f is Stream? 3", "Full-Time", new DateTime(2022, 03, 01), new DateTime(2022, 05, 31));
            // Adding Students to Courses
            c3.Students = new List<Student>() { s1, s2, s6, s7, s8 };
            s1.Courses.Add(c3);
            s2.Courses.Add(c3);
            s6.Courses.Add(c3);
            s7.Courses.Add(c3);
            s8.Courses.Add(c3);

            // Adding Assignments to Courses
            c3.Assignments = new List<Assignment>() { a2, a4, a5 };
            a2.Courses.Add(c3);
            a4.Courses.Add(c3);
            a5.Courses.Add(c3);

            // Adding Trainers to Courses
            c3.Trainers = new List<Trainer>() { t1, t3 };
            t1.Courses.Add(c3);
            t3.Courses.Add(c3);

            Course c4 = new Course(4, "Course 4", "What the f is Stream? 4", "Part-Time", new DateTime(2022, 03, 01), new DateTime(2022, 08, 31));
            // Adding Students to Courses
            c4.Students = new List<Student>() { s9, s10, s11 };
            s9.Courses.Add(c4);
            s10.Courses.Add(c4);
            s11.Courses.Add(c4);

            // Adding Assignments to Courses
            c4.Assignments = new List<Assignment>() { a1, a2, a6, a7, a8 };
            a1.Courses.Add(c4);
            a2.Courses.Add(c4);
            a6.Courses.Add(c4);
            a7.Courses.Add(c4);
            a8.Courses.Add(c4);

            // Adding Trainers to Courses
            c4.Trainers = new List<Trainer>() { t2, t4, t5 };
            t2.Courses.Add(c4);
            t4.Courses.Add(c4);
            t5.Courses.Add(c4);

            Course c5 = new Course(5, "Course 5", "What the f is Stream? 5", "Full-Time", new DateTime(2022, 03, 01), new DateTime(2022, 05, 31));
            // Adding Students to Courses
            c5.Students = new List<Student>() { s2, s3, s5, s7, s11, s13 };
            s2.Courses.Add(c5);
            s3.Courses.Add(c5);
            s5.Courses.Add(c5);
            s7.Courses.Add(c5);
            s11.Courses.Add(c5);
            s13.Courses.Add(c5);

            // Adding Assignments to Courses
            c5.Assignments = new List<Assignment>() { a9, a10, a11 };
            a9.Courses.Add(c5);
            a10.Courses.Add(c5);
            a11.Courses.Add(c5);

            // Adding Trainers to Courses
            c5.Trainers = new List<Trainer>() { t1, t2, t6, t7 };
            t1.Courses.Add(c5);
            t2.Courses.Add(c5);
            t6.Courses.Add(c5);
            t7.Courses.Add(c5);

            #endregion
            #region Populate Lists
            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13 };
            Students.AddRange(students);
            List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7 };
            Trainers.AddRange(trainers);
            List<Assignment> assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11 };
            Assignments.AddRange(assignments);
            List<Course> courses = new List<Course>() { c1, c2, c3, c4, c5 };
            Courses.AddRange(courses);
            #endregion
        }
    }
}
