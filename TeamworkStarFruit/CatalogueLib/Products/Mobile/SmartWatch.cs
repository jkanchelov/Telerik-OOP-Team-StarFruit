using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;
using CatalogueLib.Products.Struct;

namespace CatalogueLib.Products
{
    public class SmartWatch : Mobile
    {
        public SmartWatch(int ID, decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize, double Size, bool WaterResistance)
            : base(ID, price, isAvailable, brand, Memory, CPU, RAM, Model, battery, connectivity, ExpandableMemory, ScreenSize)
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
            return base.ToString() + $"\nSize: {this.Size}\nWater resistance: {this.WaterResistance}";
        }
    }
}
