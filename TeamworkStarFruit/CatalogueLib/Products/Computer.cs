using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class Computer : Product
    {
        public Computer(decimal price, bool isAvailable, Brand brand)
            :base(price,isAvailable, brand)
        {

        }
    }
}
