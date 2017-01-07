using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class Product
    {
        public bool isAvailable { get; private set; }
        public int Count { get; private set; }
        public Brand brand { get; private set; }
        public int ID { get; private set; }
        public Product(bool isAvailable, Brand brand)
        {
            this.isAvailable = isAvailable;
            this.brand = brand;
        }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Brand: {this.brand}\nNumber of available products:{this.Count}";

            }
            else
            {
                return $"Brand: {this.brand}\nProduct is not available at the moment.";
            }
        }
    }
}
