using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryCocaCola
{
    // Конкретный класс Bottle 2)
    internal class PepsiBottle : AbstractBottle
    {
        public override void Bottle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bottle Pepsi");
        }
    }

}
