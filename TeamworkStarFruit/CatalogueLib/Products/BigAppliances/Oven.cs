using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    class Oven : BigAppliances
    {
        public Oven(bool isAvailable, Brand brand) : base(isAvailable, brand)
        {
            this.ElectricOrGas = ElectricOrGas;
        }
        public string ElectricOrGas
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Electric or gas: {this.ElectricOrGas}" + base.ToString();
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}