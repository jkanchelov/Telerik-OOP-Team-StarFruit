using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class SmallAppliances : Product
    {
        public SmallAppliances(decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes)
            : base(price, isAvailable, brand)
        {
            this.Capacity = Capacity;
            this.CableLength = CableLength;
            this.Affixes = Affixes;
        }

        public double Capacity
        { get; private set; }

        public double CableLength
        { get; private set; }

        public int Affixes
        { get; private set; }

        public override string ToString()
        {

            if (this.isAvailable)
            {
                return $"Capacity: {this.Capacity}\nCable length:{this.CableLength}\nAffixes: {this.Affixes}";
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }

        }
    }
}
