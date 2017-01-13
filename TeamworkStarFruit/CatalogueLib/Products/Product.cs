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
        public Product(int ID, decimal price, bool isAvailable, Brand brand)
        {
            this.ID = ID;
            this.Price = price;
            this.isAvailable = isAvailable;
            this.brand = brand;
        }

        public override string ToString()
        {
                return $"\nBrand: {this.brand}\nProduct is available: {this.isAvailable}\n Price: {this.Price}";
        }
    }
}
