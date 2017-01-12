using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class BigAppliances : Product
    {
<<<<<<< HEAD
        public BigAppliances(int ID, decimal price, bool isAvailable, Brand brand)
            : base(ID, price, isAvailable, brand)
=======
        public BigAppliances(bool isAvailable, Brand brand)
            : base(isAvailable, brand)
>>>>>>> master
        {
            this.Color = Color;
            this.CountryOfOrigin = CountryOfOrigin;
        }

        public string Color
        { get; private set; } 

        public string CountryOfOrigin
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Color: {this.Color}\nCountry of origin:{this.CountryOfOrigin}";
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }

    }
}
