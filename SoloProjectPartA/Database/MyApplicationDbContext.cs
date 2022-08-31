using SoloProjectPartA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Database
{
    public class MyApplicationDbContext : DbContext
    {
        public MyApplicationDbContext() : base("Sindesmos")
        {
            
        }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
