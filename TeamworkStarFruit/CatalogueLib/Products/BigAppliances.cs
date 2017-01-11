using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class BigAppliances : Product
    {
        public BigAppliances(decimal price, bool isAvailable, Brand brand)
            : base(price, isAvailable, brand)
        {
        }

        public string Color
        { get; private set; } 



       
    }
}
