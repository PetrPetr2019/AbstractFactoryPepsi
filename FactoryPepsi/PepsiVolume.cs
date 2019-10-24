using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryCocaCola
{
    // Конкретный класс Pepsi Volume
    internal class PepsiVolume : AbstractVolume
    {
        public override void Volume()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Volume Bottle Pepsi:" + "0,5:литра");
        }
    }
}
