using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class Mobile : Product
    {
        public Mobile(bool isAvailable, Brand brand )
            :base(isAvailable, brand)
        {

        }
    }
}
