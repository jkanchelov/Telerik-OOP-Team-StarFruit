using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    public class Oven : BigAppliances
    {
        public Oven(int ID, decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string ElectricOrGas) 
            : base(ID, price, isAvailable, brand, Color, CountryOfBirth)
        {
            this.ElectricOrGas = ElectricOrGas;
        }
        public string ElectricOrGas
        { get; private set; }

        public override string ToString()
        {
                return base.ToString() + $"\nElectric or gas: {this.ElectricOrGas}";
        }
    }
}