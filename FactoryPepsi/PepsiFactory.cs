

using FactoryPepsi;

namespace FactoryCocaCola
{
    internal class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle Bottle()
        {
            return new PepsiBottle();
        }

        public override AbstractCover Cover()
        {
            return new PepsiCover();
        }

        public override AbstractPay Pay()
        {
            return new PepsiPay();
        }

        public override AbstractVolume Volume()
        {
            return  new PepsiVolume();
        }

        public override AbstractWater Water()
        {
            return new PepsiWater();
        }
    }

}
