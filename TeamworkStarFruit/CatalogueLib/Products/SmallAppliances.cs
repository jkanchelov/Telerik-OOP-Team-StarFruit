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
            StringBuilder stroitel = new StringBuilder();
            stroitel = stroitel.Append(string.Format("{0}", base.ToString()));
            stroitel = stroitel.Append(string.Format(" Capacity: {0}\n Cable length: {1}\n Affixes: {2}", this.Capacity, this.CableLength, this.Affixes));
            return stroitel.AppendLine().ToString();
        }
    }
}
