using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;


namespace CatalogueLib.Products
{
    class AirConditioner : BigAppliances
    {
        public AirConditioner(bool isAvailable, Brand brand) : base(isAvailable, brand)
        {
            this.TypeOfSystem = TypeOfSystem;
            this.HasWiFi = HasWiFi;
        }

        public string TypeOfSystem
        { get; private set; }

        public bool HasWiFi
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Type of air conditioning system: {this.TypeOfSystem}\nWiFi control:{this.HasWiFi}" + base.ToString();
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}
