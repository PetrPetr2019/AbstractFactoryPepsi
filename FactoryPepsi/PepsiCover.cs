using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryCocaCola
{
    class PepsiCover : AbstractCover
    {
        // Конкретные класс PepsiCover  2)
        public override void Cover()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pepsi Cap");
        }
    }
}
