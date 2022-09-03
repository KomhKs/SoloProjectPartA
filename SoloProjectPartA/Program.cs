using SoloProjectPartA.Application;
using SoloProjectPartA.Database;
using SoloProjectPartA.Enums;
using SoloProjectPartA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyApplicationDbContext db = new MyApplicationDbContext();
            int inputNumeric;
            bool invalidInput;
            SelectMenu selection;
            do
            {
                View.ViewMenu();
                string inputString = Console.ReadLine();
                bool isNumeric = int.TryParse(inputString, out _);
                while(!isNumeric)
                {
                    Console.Clear();
                    Console.WriteLine("I Am Error! Enter Numeric Input.");
                    View.ViewMenu();
                    inputString = Console.ReadLine();
                    isNumeric = int.TryParse(inputString, out _);
                }
                inputNumeric = Convert.ToInt32(inputString);
                invalidInput = inputNumeric < 0 && inputNumeric > 17;
                while (invalidInput)
                {
                    Console.WriteLine("I Am Error! Enter Input Within the Appropriate Range.");
                    inputNumeric = Convert.ToInt32(inputString);
                    invalidInput = inputNumeric < 0 && inputNumeric > 17;
                }

                Console.Clear();
                selection = (SelectMenu)inputNumeric;

                Controller.Controller1(db, selection);
            } while (selection != 0);
        }
    }
}
