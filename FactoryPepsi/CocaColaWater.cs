using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryCocaCola
{
    // Конкретные класс WaterКока - Кола 1)
    internal class CocaColaWater : AbstractWater
    {
        public override void Water()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Water Coca-Cola");
        }
    }

}
