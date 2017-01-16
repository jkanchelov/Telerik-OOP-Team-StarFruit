namespace CatalogueLib
{
    using CatalogueLib.Products.Enumerations;
    using CatalogueLib.Products.Struct;
    using System.Text;

    public abstract class Mobile : Product
    {
        public Mobile()
        {

        }

        public Mobile(int ID, decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, string battery, string connectivity, bool ExpandableMemory, double ScreenSize)
            : base(ID, price, isAvailable, brand)
        {
            this.Memory = Memory;
            this.CPU = CPU;
            this.RAM = RAM;
            this.Model = Model;
            this.battery = battery;
            this.Connectivity = Connectivity;
            this.ExpandableMemory = ExpandableMemory;
            this.ScreenSize = ScreenSize;
        }

        public int Memory { get; private set; }

        public string CPU { get; private set; }

        public int RAM { get; private set; }

        public string Model { get; private set; }

        public string battery { get; private set; }

        public string Connectivity { get; private set; }

        public bool ExpandableMemory { get; private set; }

        public double ScreenSize { get; private set; }

       public override string ToString()
        {
            StringBuilder stroitel = new StringBuilder();
            stroitel = stroitel.Append(string.Format("{0}", base.ToString()));
            stroitel = stroitel.Append(string.Format(" Model: {0}\n Screen size: {1}\n Memory: {2}\n CPU: {3}\n RAM: {4}\n Expandable memory: {5}\n Battery: {6}",this.Model,this.ScreenSize,this.Memory,this.CPU,this.RAM, this.ExpandableMemory,this.battery));
            return stroitel.AppendLine().ToString();
        }

    }
}

