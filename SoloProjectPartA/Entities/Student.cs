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
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> Assignment { get; set; } = new List<Assignment>();

        public Student()
        {

        }

        public Student(int studentId, string firstName, string lastName, DateTime dateOfBirth, decimal tuitionFees)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }
    }
}
