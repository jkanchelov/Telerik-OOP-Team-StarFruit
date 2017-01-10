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
        public SmartWatch(bool isAvailable, Brand brand) : base(isAvailable, brand)
        {
        }

        public string Model
        { get; private set; }

        public double Size
        { get; private set; }

        public int Memory
        { get; private set; }

        public double CPU
        { get; private set; }

        public bool WaterResistance
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Model: {this.Model}\nSize:{this.Size}\nMemory: {this.Memory}\nProcessor: {this.CPU}\nWater resistance: {this.WaterResistance}";

            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}
