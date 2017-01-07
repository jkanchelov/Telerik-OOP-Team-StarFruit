using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class Printer : Product
    {
        public Printer(bool isAvailable, Brand brand)
            :base(isAvailable, brand)
        {

        }
        
    }
}
