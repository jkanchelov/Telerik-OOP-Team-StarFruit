using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    class WashingMachine : BigAppliances
    {
        public WashingMachine(bool isAvailable, Brand brand) : base(isAvailable, brand)
        {
            this.LaundryCapacity = LaundryCapacity;
            this.MotorType = MotorType;
        }

        public string LaundryCapacity
        { get; private set; }

        public string MotorType
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Type of motor: {this.MotorType}\nLaundry capacity: {this.LaundryCapacity}" + base.ToString();
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}
