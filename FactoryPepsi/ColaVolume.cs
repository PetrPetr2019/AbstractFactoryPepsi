using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryCocaCola
{
    // Конкретный класс Объём Coca-Cola Обьем
    internal class ColaVolume : AbstractVolume
    {
        public override void Volume()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Volume Bottle Coca-Cola:" + "1,0:литра");
        }
    }
}
