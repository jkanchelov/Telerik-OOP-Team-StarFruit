using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class BigAppliances : Product
    {
        public BigAppliances(int ID, decimal price, bool isAvailable, Brand brand)
            : base(ID, price, isAvailable, brand)
        {
        }

        public string Color
        { get; private set; } 



       
    }
}
