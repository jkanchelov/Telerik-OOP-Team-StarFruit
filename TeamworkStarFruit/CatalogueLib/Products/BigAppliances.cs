using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class BigAppliances : Product
    {
        public BigAppliances(bool isAvailable, Brand brand)
            : base(isAvailable, brand)
        {
        }

        public string Color
        { get; private set; } 



       
    }
}
