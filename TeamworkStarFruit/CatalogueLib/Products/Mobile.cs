using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class Mobile : Product
    {
        public Mobile(bool isAvailable, Brand brand)
            : base(isAvailable, brand)
        {

        }

        public string Battery
        { get; private set; }

        public string Connectivity
        { get; private set; }

        public bool ExpandableMemory
        { get; private set; }

        public double ScreenSize
        { get; private set; }

        public override string ToString()
        {

            if (this.isAvailable)
            {
                return $"Brand: {this.brand}\nScreen size:{this.ScreenSize}\nExpandable memory: {this.ExpandableMemory}";

            }
            else
            {
                return $"The selected product is not available at the moment.";
            }

        }

    }
}

