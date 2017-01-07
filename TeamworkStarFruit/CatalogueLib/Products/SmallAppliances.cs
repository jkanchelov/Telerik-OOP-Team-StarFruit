using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class SmallAppliances : Product
    {
        public SmallAppliances(bool isAvailable, Brand brand)
            :base(isAvailable, brand)
        {

        }
    }
}
