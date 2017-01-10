using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class Computer : Product
    {
        public Computer(bool isAvailable, Brand brand)
            :base(isAvailable, brand)
        {

        }
    }
}
