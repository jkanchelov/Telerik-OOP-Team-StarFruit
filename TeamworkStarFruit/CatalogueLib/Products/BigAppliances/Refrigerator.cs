using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    class Refrigerator : BigAppliances
    {
        public Refrigerator(bool isAvailable, Brand brand) : base(isAvailable, brand)
        {
            this.TypeOfTechnology = TypeOfTechnology;
        }

        public string TypeOfTechnology
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Type of coolong system: {this.TypeOfTechnology}" +base.ToString();
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}