using SoloProjectPartA.Application;
using SoloProjectPartA.Database;
using SoloProjectPartA.Enum;
using SoloProjectPartA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloProjectPartA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            int input;
            SelectMenu selection;
            do
            {
                View.ViewMenu();

                input = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                selection = (SelectMenu)input;

                Controller.Controller1(db, selection);
            } while (selection != 0);
        }
    }
}
