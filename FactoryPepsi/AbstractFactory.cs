


using FactoryPepsi;

namespace FactoryCocaCola
{
    // Абстрактные  фабрики напитков 
    internal abstract class AbstractFactory
    {
        public abstract AbstractWater Water();
        public abstract AbstractBottle Bottle();
        public abstract AbstractCover Cover();
        public abstract AbstractVolume Volume();
        public abstract AbstractPay Pay();
    }
}
