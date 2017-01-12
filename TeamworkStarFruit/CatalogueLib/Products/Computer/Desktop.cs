using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    class Desktop : Computer
    {
        public Desktop(decimal price, bool isAvailable, Brand brand) : base(price, isAvailable, brand)
        {
        }

        public bool HasDVDRecorder
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Has DVD recorder: {this.HasDVDRecorder}";
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}
