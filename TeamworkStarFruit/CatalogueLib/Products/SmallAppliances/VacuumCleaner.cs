using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    public class VacuumCleaner : SmallAppliances
    {
        public VacuumCleaner(int ID, decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, double GarbageBagVolume)
            : base(ID, price, isAvailable, brand, Capacity, CableLength, Affixes)
        {
            this.GarbageBagVolume = GarbageBagVolume;
        }

        public double GarbageBagVolume // in litres
        { get; private set; }

        public override string ToString()
        {
                return base.ToString() + $"\nGarbage bag volume: {this.GarbageBagVolume}";
        }
    }
}
