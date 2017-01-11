using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class SmallAppliances : Product
    {
        public SmallAppliances(decimal price, bool isAvailable, Brand brand)
            :base(price, isAvailable, brand)
        {

        }
    }
}
