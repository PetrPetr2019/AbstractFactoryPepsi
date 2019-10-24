using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPepsi
{
    // Абстрактная фабрика Pay
    internal abstract class AbstractPay
    {
        public abstract void Pay(int sumBotleCola1, int sumBotleCola2);
       
    }
}
