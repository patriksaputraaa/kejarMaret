using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KejarMaret
{
    class Utility
    {
        public static void showMenu()
        {
            Console.WriteLine("\nChoose one: ");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.WriteLine("3. Quit");
        }

        public static void clearScreen()
        {
            Console.Clear();
        }
    }
}
