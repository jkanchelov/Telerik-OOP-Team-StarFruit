namespace CatalogueLib
{
    using System.Text;
    using CatalogueLib.Products.Enumerations;

    public abstract class BigAppliances : Product
    {
        public BigAppliances()
        {

        }

        public BigAppliances(int ID, decimal price, bool isAvailable, Brand brand, string Color, string CountryOfOrigin)
            : base(ID, price, isAvailable, brand)
        {
            this.Color = Color;
            this.CountryOfOrigin = CountryOfOrigin;
        }

        public string Color { get; private set; }

        public string CountryOfOrigin { get; private set; }

        public override string ToString()
        {
            StringBuilder stroitel = new StringBuilder();
            stroitel = stroitel.Append(string.Format("{0}", base.ToString()));
            stroitel = stroitel.Append(string.Format(" Color: {0}\n Country of origin: {1}", this.Color, this.CountryOfOrigin));
            return stroitel.AppendLine().ToString();
           
        }

    }
}
