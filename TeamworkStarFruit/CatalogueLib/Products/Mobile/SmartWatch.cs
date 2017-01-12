using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    class SmartWatch : Mobile
    {
<<<<<<< HEAD
        public SmartWatch(int ID, decimal price, bool isAvailable, Brand brand) : base(ID, price, isAvailable, brand)
=======
        public SmartWatch(bool isAvailable, Brand brand) : base(isAvailable, brand)
>>>>>>> master
        {
            this.Size = Size;
            this.WaterResistance = WaterResistance;
        }

        public double Size
        { get; private set; }

        public bool WaterResistance
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Model: {this.Model}\nSize:{this.Size}\nMemory: {this.Memory}\nProcessor: {this.CPU}\nWater resistance: {this.WaterResistance}" + base.ToString();

            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}
