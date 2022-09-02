namespace SoloProjectPartA.Migrations
{
    using SoloProjectPartA.Entities;
    using System;
    using System.Collections.Generic;
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
            Student s1 = new Student("Kostas", "Mpaladimas", new DateTime(1984, 05, 16), 2500);
            Student s2 = new Student("Giorgos", "Dimoylas", new DateTime(1954, 06, 17), 2250);
            Student s3 = new Student("Alexandros", "Poylopoylos", new DateTime(1994, 07, 18), 2250);
            Student s4 = new Student("Sotiris", "Xabales", new DateTime(1992, 08, 19), 2500);
            Student s5 = new Student("Nikos", "Kollaros", new DateTime(1997, 08, 20), 2250);
            Student s6 = new Student("Stayros", "Sionis", new DateTime(1987, 09, 21), 2500);
            Student s7 = new Student("Stathis", "Karachalios", new DateTime(1986, 10, 22), 2250);
            Student s8 = new Student("Tasos", "Student Last Name 8", new DateTime(2001, 11, 23), 2500);
            Student s9 = new Student("Giannis", "Galanakis", new DateTime(2000, 12, 24), 2500);
            Student s10 = new Student("Aris", "Karagiannis", new DateTime(1984, 01, 25), 2500);
            Student s11 = new Student("Alkis", "Pagoulatos", new DateTime(1985, 02, 26), 2250);
            Student s12 = new Student("Theodoros", "Sioylas", new DateTime(1987, 01, 16), 2500);
            Student s13 = new Student("Nikolaos", "Polemarchakis", new DateTime(1986, 03, 27), 2250);
            context.Students.AddOrUpdate(s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12,s13);
            context.SaveChanges();
            #endregion
            #region Seeding Trainers
            Trainer t1 = new Trainer("Ektoras", "Gatsos", "C#");
            Trainer t2 = new Trainer("Nikolaos", "Polizos", "Power Electronics");
            Trainer t3 = new Trainer("Georgios", "Drakakis", "Theory of electrical circuits");
            Trainer t4 = new Trainer("Ioannis", "Siderakis", "High Voltages");
            Trainer t5 = new Trainer("Aristedes", "Kyprakis", "Biomechanical Automations");
            Trainer t6 = new Trainer("Mixalis", "Sfakiotakis", "Systems of Automated Control");
            Trainer t7 = new Trainer("Dimitrios", "Minadakis", "Microcontrolers");
            context.Trainers.AddOrUpdate(t1, t2, t3, t4, t5, t6, t7);
            context.SaveChanges();
            #endregion

            #region Seeding Assignments
            Assignment a1 = new Assignment("Assignment 1", "Description 1", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a1.Students = new List<Student> { s1, s3, s5 };

            Assignment a2 = new Assignment("Assignment 2", "Description 2", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a2.Students = new List<Student> { s2, s4, s6, s7 };

            Assignment a3 = new Assignment("Assignment 3", "Description 3", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a3.Students = new List<Student> { s2, s3, s5, s7, s8, s10 };

            Assignment a4 = new Assignment("Assignment 4", "Description 4", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a4.Students = new List<Student> { s1, s11 };

            Assignment a5 = new Assignment("Assignment 5", "Description 5", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a5.Students = new List<Student> { s3, s6, s9, s11 };

            Assignment a6 = new Assignment("Assignment 6", "Description 6", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a6.Students = new List<Student> { s1, s2, s3, s4, s5 };

            Assignment a7 = new Assignment("Assignment 7", "Description 7", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a7.Students = new List<Student> { s6, s7, s8, s9 };

            Assignment a8 = new Assignment("Assignment 8", "Description 8", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a8.Students = new List<Student> { s10, s11 };

            Assignment a9 = new Assignment("Assignment 9", "Description 9", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a9.Students = new List<Student> { s5, s7, s9, s11 };

            Assignment a10 = new Assignment("Assignment 10", "Description 10", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a10.Students = new List<Student> { s1, s6, s9, s10, s11 };

            Assignment a11 = new Assignment("Assignment 11", "Description 11", new DateTime(2022, 03, 31), 50, 100);
            // Adding Students to Assignments
            a11.Students = new List<Student> { s3, s4, s6, s7, s10 };
            #endregion
            #region Seeding Courses
            Course c1 = new Course("Course 1", "What the f is Stream? 1", "Part-Time", new DateTime(2022, 03, 01), new DateTime(2022, 08, 31));
            // Adding Students to Courses
            c1.Students = new List<Student>() { s1, s3, s12 };

            // Adding Assignments to Courses
            c1.Assignments = new List<Assignment>() { a2, a3, a5, a7, a11 };

            // Adding Trainers to Courses
            c1.Trainers = new List<Trainer>() { t1, t4, t6 };

            Course c2 = new Course("Course 2", "What the f is Stream? 2", "Full-Time", new DateTime(2022, 03, 01), new DateTime(2022, 05, 31));
            // Adding Students to Courses
            c2.Students = new List<Student>() { s2, s4, s5 };

            // Adding Assignments to Courses
            c2.Assignments = new List<Assignment>() { a1, a3 };

            // Adding Trainers to Courses
            c2.Trainers = new List<Trainer>() { t2, t3, t5, t7 };

            Course c3 = new Course("Course 3", "What the f is Stream? 3", "Full-Time", new DateTime(2022, 03, 01), new DateTime(2022, 05, 31));
            // Adding Students to Courses
            c3.Students = new List<Student>() { s1, s2, s6, s7, s8 };

            // Adding Assignments to Courses
            c3.Assignments = new List<Assignment>() { a2, a4, a5 };

            // Adding Trainers to Courses
            c3.Trainers = new List<Trainer>() { t1, t3 };

            Course c4 = new Course("Course 4", "What the f is Stream? 4", "Part-Time", new DateTime(2022, 03, 01), new DateTime(2022, 08, 31));
            // Adding Students to Courses
            c4.Students = new List<Student>() { s9, s10, s11 };

            // Adding Assignments to Courses
            c4.Assignments = new List<Assignment>() { a1, a2, a6, a7, a8 };

            // Adding Trainers to Courses
            c4.Trainers = new List<Trainer>() { t2, t4, t5 };

            Course c5 = new Course("Course 5", "What the f is Stream? 5", "Full-Time", new DateTime(2022, 03, 01), new DateTime(2022, 05, 31));
            // Adding Students to Courses
            c5.Students = new List<Student>() { s2, s3, s5, s7, s11, s13 };

            // Adding Assignments to Courses
            c5.Assignments = new List<Assignment>() { a9, a10, a11 };

            // Adding Trainers to Courses
            c5.Trainers = new List<Trainer>() { t1, t2, t6, t7 };

            #endregion

            context.Assignments.AddOrUpdate(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11);

            context.Courses.AddOrUpdate(c1, c2, c3, c4, c5);

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

            s1.Courses = new List<Course> {c1 c3};
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

            t1.Courses = new List<Course> {c1, c2, c3};
            t2.Courses =  new List<Course> {c2, c4, c5};
            t3.Courses =  new List<Course> {c2, c3};
            t4.Courses =  new List<Course> {c1, c4};
            t5.Courses =  new List<Course> {c2, c4};
            t6.Courses =  new List<Course> {c1, c5};
            t7.Courses =  new List<Course> {c2, c5};

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
            //#region Populate Lists
            //List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13 };
            //Students.AddRange(students);
            //List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7 };
            //Trainers.AddRange(trainers);
            //List<Assignment> assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11 };
            //Assignments.AddRange(assignments);
            //List<Course> courses = new List<Course>() { c1, c2, c3, c4, c5 };
            //Courses.AddRange(courses);
            //#endregion
        }
    }
}
