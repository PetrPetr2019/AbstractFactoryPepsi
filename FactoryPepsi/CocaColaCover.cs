using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryCocaCola
{
    // Конкретные класс CocaColaCover 1)
    internal class CocaColaCover : AbstractCover
    {
        public override void Cover()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Coca-Cola Cap");
        }
    }

}
