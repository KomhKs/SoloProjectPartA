namespace SoloProjectPartA.Migrations
{
    using SoloProjectPartA.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SoloProjectPartA.Database.MyApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SoloProjectPartA.Database.MyApplicationDbContext context)
        {
            #region Seeding Students
            Student s1 = new Student() { FirstName = "Kostas", LastName = "Mpaladimas", DateOfBirth = new DateTime(1984, 05, 16), TuitionFees = 2500 };
            Student s2 = new Student() { FirstName = "Giorgos", LastName = "Dimoylas", DateOfBirth = new DateTime(1954, 06, 17), TuitionFees = 2250 };
            Student s3 = new Student() { FirstName = "Alexandros", LastName = "Poylopoylos", DateOfBirth = new DateTime(1994, 07, 18), TuitionFees = 2250 };
            Student s4 = new Student() { FirstName = "Sotiris", LastName = "Xabales", DateOfBirth = new DateTime(1992, 08, 19), TuitionFees = 2500 };
            Student s5 = new Student() { FirstName = "Nikos", LastName = "Kollaros", DateOfBirth = new DateTime(1997, 08, 20), TuitionFees = 2250 };
            Student s6 = new Student() { FirstName = "Stayros", LastName = "Sionis", DateOfBirth = new DateTime(1987, 09, 21), TuitionFees = 2500 };
            Student s7 = new Student() { FirstName = "Stathis", LastName = "Karachalios", DateOfBirth = new DateTime(1986, 10, 22), TuitionFees = 2250 };
            Student s8 = new Student() { FirstName = "Tasos", LastName = "Student Last Name 8", DateOfBirth = new DateTime(2001, 11, 23), TuitionFees = 2500 };
            Student s9 = new Student() { FirstName = "Giannis", LastName = "Galanakis", DateOfBirth = new DateTime(2000, 12, 24), TuitionFees = 2500 };
            Student s10 = new Student() { FirstName = "Aris", LastName = "Karagiannis", DateOfBirth = new DateTime(1984, 01, 25), TuitionFees = 2500 };
            Student s11 = new Student() { FirstName = "Alkis", LastName = "Pagoulatos", DateOfBirth = new DateTime(1985, 02, 26), TuitionFees = 2250 };
            Student s12 = new Student() { FirstName = "Theodoros", LastName = "Sioylas", DateOfBirth = new DateTime(1987, 01, 16), TuitionFees = 2500 };
            Student s13 = new Student() { FirstName = "Nikolaos", LastName = "Polemarchakis", DateOfBirth = new DateTime(1986, 03, 27), TuitionFees = 2250 };
            context.Students.AddOrUpdate(x => new { x.FirstName, x.LastName }, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13);
            context.SaveChanges();
            #endregion

            #region Seeding Trainers
            Trainer t1 = new Trainer() { FirstName = "Ektoras", LastName = "Gatsos", Subject = "C#"};
            Trainer t2 = new Trainer() { FirstName = "Nikolaos", LastName = "Polizos", Subject = "Power Electronics" };
            Trainer t3 = new Trainer() { FirstName = "Georgios", LastName = "Drakakis", Subject = "Theory of electrical circuits" };
            Trainer t4 = new Trainer() { FirstName = "Ioannis", LastName = "Siderakis", Subject = "High Voltages" };
            Trainer t5 = new Trainer() { FirstName = "Aristedes", LastName = "Kyprakis", Subject = "Biomechanical Automations" };
            Trainer t6 = new Trainer() { FirstName = "Mixalis", LastName = "Sfakiotakis", Subject = "Systems of Automated Control" };
            Trainer t7 = new Trainer() { FirstName = "Dimitrios", LastName = "Minadakis", Subject = "Microcontrolers" };
            context.Trainers.AddOrUpdate(x => new { x.FirstName, x.LastName },t1, t2, t3, t4, t5, t6, t7);
            context.SaveChanges();
            #endregion

            #region Seeding Assignments
            Assignment a1 = new Assignment("Steam Application", "Create a Steam online application", new DateTime(2022, 03, 31), 50, 100);
            Assignment a2 = new Assignment("Basic Chocolate Factory", "Create a program that implements a chocolate factory.", new DateTime(2022, 03, 31), 50, 100);
            Assignment a3 = new Assignment("Pong ", "Create a pong application", new DateTime(2022, 03, 31), 50, 100);
            Assignment a4 = new Assignment("Tetris", "Create a Tetris application", new DateTime(2022, 03, 31), 50, 100);
            Assignment a5 = new Assignment("Space Invaders", "Create a basic Spae Invaders Game.", new DateTime(2022, 03, 31), 50, 100);
            Assignment a6 = new Assignment("Sudoku", "Create a sudoku game", new DateTime(2022, 03, 31), 50, 100);
            Assignment a7 = new Assignment("Lotto", "Create a Lotto draw application", new DateTime(2022, 03, 31), 50, 100);
            Assignment a8 = new Assignment("Sudoku Solver", "Create a solver for Sudoku game", new DateTime(2022, 03, 31), 50, 100);
            Assignment a9 = new Assignment("Chess Tournament", "Create an app for Chess Tournament.", new DateTime(2022, 03, 31), 50, 100);
            Assignment a10 = new Assignment("Morse Code", "Create an app that takes a string input in . and - and transforms it to text ia morse code.", new DateTime(2022, 03, 31), 50, 100);
            Assignment a11 = new Assignment("Boolean Algebra Solver", "Create an application that solves basic boolean algebra equations.", new DateTime(2022, 03, 31), 50, 100);
            context.Assignments.AddOrUpdate(x => x.Title, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11);
            context.SaveChanges();
            #endregion

            #region Seeding Courses
            Course c1 = new Course("C#", "What the f is Stream? 1", "Part-Time", new DateTime(2022, 03, 01), new DateTime(2022, 08, 31));
            Course c2 = new Course("C++", "What the f is Stream? 2", "Full-Time", new DateTime(2022, 03, 01), new DateTime(2022, 05, 31));
            Course c3 = new Course("C", "What the f is Stream? 3", "Full-Time", new DateTime(2022, 03, 01), new DateTime(2022, 05, 31));
            Course c4 = new Course("Lisp", "What the f is Stream? 4", "Part-Time", new DateTime(2022, 03, 01), new DateTime(2022, 08, 31));
            Course c5 = new Course("Basic", "What the f is Stream? 5", "Full-Time", new DateTime(2022, 03, 01), new DateTime(2022, 05, 31));
            context.Courses.AddOrUpdate(x => x.Title, c1, c2, c3, c4, c5);
            context.SaveChanges();
            #endregion            
            
            #region Populating Lists
            //Adding Students To Assignments
            a1.Students = new List<Student> { s1, s3, s5 };
            a2.Students = new List<Student> { s2, s4, s6, s7 };
            a3.Students = new List<Student> { s2, s3, s5, s7, s8, s10 };
            a4.Students = new List<Student> { s1, s11 };
            a5.Students = new List<Student> { s3, s6, s9, s11 };
            a6.Students = new List<Student> { s1, s2, s3, s4, s5 };
            a7.Students = new List<Student> { s6, s7, s8, s9 };
            a8.Students = new List<Student> { s10, s11 };
            a9.Students = new List<Student> { s5, s7, s9, s11 };
            a10.Students = new List<Student> { s1, s6, s9, s10, s11 };
            a11.Students = new List<Student> { s3, s4, s6, s7, s10 };

            context.SaveChanges();
            //Adding Assignments To Students
            s1.Assignments = new List<Assignment> {a1, a4, a6, a10 };
            s2.Assignments = new List<Assignment> {a2, a3, a6};
            s3.Assignments = new List<Assignment> {a1, a3, a5, a6, a11};
            s4.Assignments = new List<Assignment> {a2, a6, a11 };
            s5.Assignments = new List<Assignment> {a1, a3, a6, a9 };
            s6.Assignments = new List<Assignment> {a2, a5, a7, a11 };
            s7.Assignments = new List<Assignment> {a2, a3, a7, a9, a11 };
            s8.Assignments = new List<Assignment> {a3, a7 };
            s9.Assignments = new List<Assignment> {a5, a7, a9, a11 };
            s10.Assignments = new List<Assignment> {a3, a8, a10, a11 };
            s11.Assignments = new List<Assignment> {a4, a5, a8, a9, a10 };
            s12.Assignments = new List<Assignment> {a1, a2, a4, a5, a11 };
            s13.Assignments = new List<Assignment> {a1, a4, a7, a8, a10 };

            context.SaveChanges();
            //Adding Students To Courses
            c1.Students = new List<Student>() { s1, s3, s12 };
            c2.Students = new List<Student>() { s2, s4, s5 };
            c3.Students = new List<Student>() { s1, s2, s6, s7, s8 };
            c4.Students = new List<Student>() { s9, s10, s11 };
            c5.Students = new List<Student>() { s2, s3, s5, s7, s11, s13 };

            context.SaveChanges();
            //Adding Assignments To Courses
            c1.Assignments = new List<Assignment>() { a2, a3, a5, a7, a11 };
            c2.Assignments = new List<Assignment>() { a1, a3 };
            c3.Assignments = new List<Assignment>() { a2, a4, a5 };
            c4.Assignments = new List<Assignment>() { a1, a2, a6, a7, a8 };
            c5.Assignments = new List<Assignment>() { a9, a10, a11 };

            context.SaveChanges();
            //Adding Trainers To Courses
            c1.Trainers = new List<Trainer>() { t1, t4, t6 };
            c2.Trainers = new List<Trainer>() { t2, t3, t5, t7 };
            c3.Trainers = new List<Trainer>() { t1, t3 };
            c4.Trainers = new List<Trainer>() { t2, t4, t5 };
            c5.Trainers = new List<Trainer>() { t1, t2, t6, t7 };

            context.SaveChanges();
            //Adding Courses To Students
            s1.Courses = new List<Course> {c1, c3};
            s2.Courses = new List<Course> {c2, c3, c5};
            s3.Courses = new List<Course> {c1, c5};
            s4.Courses = new List<Course> {c2};
            s5.Courses = new List<Course> {c2, c5};
            s6.Courses = new List<Course> {c3};
            s7.Courses = new List<Course> {c3, c5};
            s8.Courses = new List<Course> {c3};
            s9.Courses = new List<Course> {c4};
            s10.Courses = new List<Course> {c4};
            s11.Courses = new List<Course> {c4, c5};
            s12.Courses = new List<Course> {c1};
            s13.Courses = new List<Course> {c5};

            context.SaveChanges();
            //Adding Courses To Trainers
            t1.Courses = new List<Course> {c1, c2, c3};
            t2.Courses =  new List<Course> {c2, c4, c5};
            t3.Courses =  new List<Course> {c2, c3};
            t4.Courses =  new List<Course> {c1, c4};
            t5.Courses =  new List<Course> {c2, c4};
            t6.Courses =  new List<Course> {c1, c5};
            t7.Courses =  new List<Course> {c2, c5};

            context.SaveChanges();
            //Adding Courses To Assignments
            a1.Courses = new List<Course> {c2, c4};
            a2.Courses = new List<Course> {c1, c3, c4};
            a3.Courses = new List<Course> {c1, c2};
            a4.Courses = new List<Course> {c3};
            a5.Courses = new List<Course> {c1, c3};
            a6.Courses = new List<Course> {c4};
            a7.Courses = new List<Course> {c1, c4};
            a8.Courses = new List<Course> {c4};
            a9.Courses = new List<Course> {c5};
            a10.Courses = new List<Course> {c5};
            a10.Courses = new List<Course> {c1, c5};

            context.SaveChanges();
            #endregion
        }
    }
}
