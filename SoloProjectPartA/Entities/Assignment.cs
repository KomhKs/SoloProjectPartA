﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Entities
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDate { get; set; }
        public float OralMark { get; set; }
        public float TotalMark { get; set; }
        // Navigation Properties
        public ICollection<Course> Courses { get; set; }
        public ICollection<Student> Students { get; set; }
        public Assignment()
        {

        }
        public Assignment(string title, string description, DateTime subDateTime, float oralMark, float totalMark)
        {
            Title = title;
            Description = description;
            SubDate = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public static implicit operator List<object>(Assignment v)
        {
            throw new NotImplementedException();
        }
    }
}
