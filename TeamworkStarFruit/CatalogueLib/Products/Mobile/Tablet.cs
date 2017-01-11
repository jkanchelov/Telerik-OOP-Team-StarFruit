using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    class Tablet : Mobile
    {
        public Tablet(decimal price, bool isAvailable, Brand brand) : base(price, isAvailable, brand)
        {
        }

        public string Model
        { get; private set; }

        public int Memory
        { get; private set; }

        public double CPU
        { get; private set; }

        public string GPU
        { get; private set; }

        public int RAM
        { get; private set; }

        public string OperatingSystem
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Model: {this.Model}\nScreen Size: {this.ScreenSize}\nMemory: {this.Memory}\nProcessor: {this.CPU}\nRAM: {this.RAM}\nPhone GPU: {this.GPU}\nOperating System: {this.OperatingSystem}\nConnectivity: {this.Connectivity}\nBattery: {this.Battery}";

            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}