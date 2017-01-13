using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    public class WashingMachine : BigAppliances
    {
        public WashingMachine(int ID, decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string LaundryCapacity, string MotorType) 
            : base(ID,price, isAvailable, brand, Color, CountryOfBirth)
        {
            this.LaundryCapacity = LaundryCapacity;
            this.MotorType = MotorType;
        }

        public string LaundryCapacity
        { get; private set; }

        public string MotorType
        { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $"\nType of motor: {this.MotorType}\nLaundry capacity: {this.LaundryCapacity}";
        }
    }
}
