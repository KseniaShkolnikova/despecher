using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispetcher
{
    internal class Class1
    {
        public static int strelka(int position, int minStrelocka, int maxStrelochka)
        {
            ConsoleKeyInfo knopka;
            do
            {

                knopka = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");
                if (knopka.Key == (ConsoleKey)knopki.UpArrow && position != minStrelocka)
                {
                    position--;

                }
                else if (knopka.Key == (ConsoleKey)knopki.DownArrow && position != maxStrelochka)
                {
                    position++;

                }
                else if (knopka.Key == (ConsoleKey)knopki.Backspace)
                {
                    Class3.ocnov();
                }
                else if (knopka.Key == (ConsoleKey)knopki.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("   Пока");
                    Environment.Exit(0);
                }
                else if (knopka.Key == (ConsoleKey)knopki.D)
                {
                    Class3.ydal();
                }
                else if (knopka.Key == (ConsoleKey)knopki.Delete)
                {
                    Class3.ydalvse();
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

            } while (knopka.Key != ConsoleKey.Enter);
            return position;
        }
    }
}
