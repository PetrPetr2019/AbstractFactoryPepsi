using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryCocaCola
{
    // Конкретный класс WaterPepsi 2)
    internal class PepsiWater : AbstractWater
    {
        public override void Water()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Water Pepsi");
        }
    }
}
