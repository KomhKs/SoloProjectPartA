using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Entities
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        public Trainer()
        {

        }
        public Trainer(int trainerId, string firstName, string lastName, string subject)
        {
            TrainerId = trainerId;
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }
    }
}
