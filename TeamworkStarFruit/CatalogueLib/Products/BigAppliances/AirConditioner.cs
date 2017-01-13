using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;


namespace CatalogueLib.Products
{
    public class AirConditioner : BigAppliances
    {
        public AirConditioner(int ID, decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string TypeOfSystem, bool HasWiFi)
            : base(ID, price, isAvailable, brand, Color, CountryOfBirth)
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
            return base.ToString() + $"\nType of air conditioning system: {this.TypeOfSystem}\nWiFi control:{this.HasWiFi}";
        }
    }
}
