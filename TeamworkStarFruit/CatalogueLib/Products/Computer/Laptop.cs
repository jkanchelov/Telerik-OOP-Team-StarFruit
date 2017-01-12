using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    class Laptop : Computer
    {
        public Laptop(decimal price, bool isAvailable, Brand brand) : base(price, isAvailable, brand)
        {

        }
        public int HowManyUSBPorts
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Ammount of USB ports: {this.HowManyUSBPorts}";
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }

        }
    }
}
