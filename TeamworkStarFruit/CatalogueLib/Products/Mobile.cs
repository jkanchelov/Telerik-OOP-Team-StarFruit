namespace CatalogueLib
{
    using CatalogueLib.Products.Enumerations;
    using CatalogueLib.Products.Struct;

    public abstract class Mobile : Product
    {
        public Mobile()
        {

        }

        public Mobile(int ID, decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize)
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

        public Battery battery { get; private set; }

        public string Connectivity { get; private set; }

        public bool ExpandableMemory { get; private set; }

        public double ScreenSize { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $"\nModel:{this.Model}\nScreen size:{this.ScreenSize}\nMemory: {this.Memory}\nCPU: {this.CPU}\nRAM: {this.RAM} Expandable memory: {this.ExpandableMemory}\nBattery: {this.battery}";
        }

    }
}

