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
<<<<<<< HEAD
        public Tablet(int ID, decimal price, bool isAvailable, Brand brand) : base(ID, price, isAvailable, brand)
=======
        public Tablet(bool isAvailable, Brand brand) : base(isAvailable, brand)
>>>>>>> master
        {
            this.GPU = GPU;
            this.OperatingSystem = OperatingSystem;
        }

        public string GPU
        { get; private set; }

        public string OperatingSystem
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Model: {this.Model}\nScreen Size: {this.ScreenSize}\nMemory: {this.Memory}\nProcessor: {this.CPU}\nRAM: {this.RAM}\nPhone GPU: {this.GPU}\nOperating System: {this.OperatingSystem}\nConnectivity: {this.Connectivity}\nBattery: {this.Battery}" + base.ToString();

            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}