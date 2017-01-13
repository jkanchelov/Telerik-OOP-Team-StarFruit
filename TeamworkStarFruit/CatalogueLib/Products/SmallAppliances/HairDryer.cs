using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    public class HairDryer : SmallAppliances
    {
        public HairDryer(int ID, decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, int DifferentSpeeds)
            : base(ID, price, isAvailable, brand, Capacity, CableLength, Affixes)
        {
            this.DifferentSpeeds = DifferentSpeeds;
        }

        public int DifferentSpeeds
        { get; private set; }

        public override string ToString()
        {
                return base.ToString() + $"\nDifferent speeds: {this.DifferentSpeeds}";
        }
    }
}
