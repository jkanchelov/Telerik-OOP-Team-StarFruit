using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    class HairDryer : SmallAppliances
    {
        public HairDryer(decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, int DifferentSpeeds)
            : base(price, isAvailable, brand, Capacity, CableLength, Affixes)
        {
            this.DifferentSpeeds = DifferentSpeeds;
        }

        public int DifferentSpeeds
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Different speeds: {this.DifferentSpeeds}";

            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}
