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
            Console.WriteLine("Tralala");
        }
    }
}
