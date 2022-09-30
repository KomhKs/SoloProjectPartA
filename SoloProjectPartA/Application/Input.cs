using SoloProjectPartA.Entities;
using SoloProjectPartA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA.Application
{
    public class Input
    {
        public static void ReadStudent(out string name, out string surname, out decimal tuitionFees, out string dateOfBirth)
        {
            Console.WriteLine("Give Student Name");
            name = Console.ReadLine();
            Console.WriteLine("Give Student Surname");
            surname = Console.ReadLine();
            Console.WriteLine("Give Student Tuition Fees");
            tuitionFees = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Give Student Date of Birth (yyyy/mm/dd)");
            dateOfBirth = Console.ReadLine();
        }
        public static void ReadTrainer(out string name, out string surname, out string subject)
        {
            Console.WriteLine("Give Trainer Name");
            name = Console.ReadLine();
            Console.WriteLine("Give Trainer Surname");
            surname = Console.ReadLine();
            Console.WriteLine("Give Trainer Subject");
            subject = Console.ReadLine();
        }
        public static void ReadCourse(out string title, out string type, out string stream, out string startDate, out string endDate)
        {
            Console.WriteLine("Give Course Title");
            title = Console.ReadLine();
            Console.WriteLine("Give Course Type");
            type = Console.ReadLine();
            Console.WriteLine("Give Course Stream");
            stream = Console.ReadLine();
            Console.WriteLine("Give Course Start Date (yyyy/mm/dd)");
            startDate = Console.ReadLine();
            Console.WriteLine("Give Course End Date (yyyy/mm/dd)");
            endDate = Console.ReadLine();
        }
        public static void ReadAssignment(out string title, out string description, out string subDate, out float oralMark, out float totalMark)
        {
            Console.WriteLine("Give Assignment Title");
            title = Console.ReadLine();
            Console.WriteLine("Give Assignment Description");
            description = Console.ReadLine();
            Console.WriteLine("Give Assignment Start Date of Birth (yyyy/mm/dd)");
            subDate = Console.ReadLine();
            Console.WriteLine("Give Assignment Oral Mark");
            oralMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give Assignment Total Mark");
            totalMark = Convert.ToInt32(Console.ReadLine());
        }
    }
}
