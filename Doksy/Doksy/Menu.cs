using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doksy
{
    class Menu
    {
        string[] options;

        public Menu(string[] optionsMenu)
        {
            options = optionsMenu;
        }

        private int Longhest()
        {
            int length = 0;
            for (int i = 0; i < options.Length; i++)
            {
                if (options[i].Length > length)
                {
                    length = options[i].Length;
                }
            }
            return length;
        }

        public int Open()
        {
            Console.Clear();
            int length = Longhest();
            int nr_option = 0;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0,0);  //ustawiam kursor w lewym rogu ab menu rysowało sie w tym samym miejscu
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == nr_option)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.WriteLine(options[i].PadRight(length));
                }
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.UpArrow && nr_option > 0)
                {
                    nr_option--;
                }
                else if (key.Key == ConsoleKey.DownArrow && nr_option < options.Length - 1)
                {
                    nr_option++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    nr_option = -1; // -1 option that does not exist.
                }
            } while (key.Key != ConsoleKey.Escape && key.Key != ConsoleKey.Enter);

            Console.ResetColor();
            return nr_option;
        }
    }

}