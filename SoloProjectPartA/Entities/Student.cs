using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal TuitionFees { get; set; }
        // Navigation Properties
        //public int CourseId { get; set; }
        public ICollection<Course> Courses { get; set; }
        //public int AssignmentId { get; set; }
        public ICollection<Assignment> Assignments { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, decimal tuitionFees)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }
    }
}
