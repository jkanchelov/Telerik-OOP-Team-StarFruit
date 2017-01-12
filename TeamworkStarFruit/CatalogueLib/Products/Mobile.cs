using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class Mobile : Product
    {
        public Mobile(bool isAvailable, Brand brand)
            : base(isAvailable, brand)
        {
            this.Memory = Memory;
            this.CPU = CPU;
            this.RAM = RAM;
            this.Model = Model;
            this.Battery = Battery;
            this.Connectivity = Connectivity;
            this.ExpandableMemory = ExpandableMemory;
            this.ScreenSize = ScreenSize;
        }

        public int Memory
        { get; private set; }

        public string CPU
        { get; private set; }

        public int RAM
        { get; private set; }

        public string Model
        { get;  private set;}

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
                return $"Brand: {this.brand}\nModel:{this.Model}\nScreen size:{this.ScreenSize}\nMemory: {this.Memory}\nCPU: {this.CPU}\nRAM: {this.RAM} Expandable memory: {this.ExpandableMemory}\nBattery: {this.Battery}";
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }

        }

    }
}

