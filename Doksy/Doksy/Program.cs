using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doksy
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu(new string[] {
                "Customer Categorie",
                "All avalible docks",
                "Exit" });

            int decision;
            do
            {
                decision = mainMenu.Open();
                if (decision == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Customer Categorie");
                    Console.ReadKey();
                }
                else if (decision == 1)
                {
                    Console.Clear();
                    Console.WriteLine("All avalible docks");
                    Console.ReadKey();
                }

            } while (decision != 2 && decision != -1);



        }
    }
}
