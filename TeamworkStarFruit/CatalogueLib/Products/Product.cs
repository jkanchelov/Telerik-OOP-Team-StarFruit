using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class Product
    {
        public decimal Price { get; private set; }
        public bool isAvailable { get; private set; }
        public int Count { get; private set; }
        public Brand brand { get; private set; }
        public int ID { get; private set; }
        public Product(decimal price, bool isAvailable, Brand brand)
        {
            this.Price = price;
            this.isAvailable = isAvailable;
            this.brand = brand;
        }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Brand: {this.brand}\nNumber of available products:{this.Count}\n Price: {this.Price}";

            }
            else
            {
                return $"Brand: {this.brand}\nPrice: {this.Price}\nProduct is not available at the moment.";
            }
        }
    }
}
