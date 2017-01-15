namespace CatalogueLib
{
    using System.Text;

    using CatalogueLib.Products.Enumerations;

    public abstract class Product
    {
        public decimal Price { get; private set; }
        public bool IsAvailable { get; private set; }
        public int Count { get; private set; }
        public Brand Brand { get; private set; }
        public int ID { get; private set; }

        public Product()
        {

        }

        public Product(int ID, decimal price, bool isAvailable, Brand brand)
        {
            this.ID = ID;
            this.Price = price;
            this.IsAvailable = isAvailable;
            this.Brand = brand;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append('-', 42);
            output.AppendLine();
            output.AppendLine(string.Format("ID:[{0}] Brand:{1} available:{2} Price:{3}",
                this.ID,this.Brand,
                this.IsAvailable == true?"Yes":"No",
                this.Price));
            return output.ToString();
        }
    }
}
