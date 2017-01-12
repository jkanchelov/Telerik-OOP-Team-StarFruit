using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    class MobilePhone : Mobile
    {
<<<<<<< HEAD
        public MobilePhone(int ID, decimal price, bool isAvailable, Brand brand) : base(ID, price, isAvailable, brand)
=======
        public MobilePhone(bool isAvailable, Brand brand, string GPU, string OperatingSystem) : base(isAvailable, brand)
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
                return $"Model: {this.Model}\nScreen Size: {this.ScreenSize}\nMemory: {this.Memory}\nProcessor: {this.CPU}\nPhone GPU: {this.RAM}\n RAM: {this.RAM}\nOperating System: {this.OperatingSystem}" + base.ToString();

            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}
