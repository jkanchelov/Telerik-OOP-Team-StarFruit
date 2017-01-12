using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    class VacuumCleaner : SmallAppliances
    {
        public VacuumCleaner(decimal price, bool isAvailable, Brand brand) : base(price, isAvailable, brand)
        {
        }

        public double GarbageBagVolume // in litres
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Garbage bag volume: {this.GarbageBagVolume}";
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }

        }
    }
}
