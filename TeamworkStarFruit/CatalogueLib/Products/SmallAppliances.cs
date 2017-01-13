namespace CatalogueLib
{
    using CatalogueLib.Products.Enumerations;

    public abstract class SmallAppliances : Product
    {
        public SmallAppliances()
        {

        }

        public SmallAppliances(int ID, decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes)
            : base(ID, price, isAvailable, brand)
        {
            this.Capacity = Capacity;
            this.CableLength = CableLength;
            this.Affixes = Affixes;
        }

        public double Capacity { get; private set; }

        public double CableLength { get; private set; }

        public int Affixes { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $"\nCapacity: {this.Capacity}\nCable length:{this.CableLength}\nAffixes: {this.Affixes}";
        }
    }
}
