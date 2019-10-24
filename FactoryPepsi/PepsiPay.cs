using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPepsi
{
    // Конкретный класс PepsiPay
    internal class PepsiPay : AbstractPay
    {
        public override void Pay(int sumBotleCocaCola1, int sumBotleCola2)
        {
            Console.WriteLine("Бутылка стоит 33");
        }
    }
}
