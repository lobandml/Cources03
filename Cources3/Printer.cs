using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources3
{
    class Printer
    {

        public  void Print(string value)
        {
            //Из любого класса-наследника получим 
            bool isPrinter = this.GetType() == typeof(Printer);
            if (isPrinter)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }

            Console.WriteLine(value);
            if (isPrinter)
            {
                Console.ResetColor();
            }
        }
    }
}
