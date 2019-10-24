using System;
using System.Collections.Generic;
using System.Text;
using FactoryPepsi;


namespace FactoryCocaCola
{
    internal class Client
    {
        private readonly AbstractWater water;
        private readonly AbstractBottle bottle;
        private readonly AbstractCover cover;
        private readonly AbstractVolume volume;
        private readonly AbstractPay pay;
        // Конструктор
        public Client(AbstractFactory factory)
        {
            water = factory.Water();
            bottle = factory.Bottle();
            cover = factory.Cover();
            volume = factory.Volume();
            pay = factory.Pay();
           

        }

        public void Water()
        {
            water.Water();
        }

        public void Bottle()
        {
            bottle.Bottle();
        }

        public void Cover()
        {
            cover.Cover();
        }

        public void Volume()
        {
           volume.Volume();
        }

        public void Pay()
        {
           pay.Pay(sumBotleCola1: 70, sumBotleCola2: 200);
        }

    }
}
