using CatalogueLib.Products;
using CatalogueLib.Products.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLib
{
    public interface IBigAppliancesFactory
    {
        AirConditioner CreateAirConditioner(decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string TypeOfSystem, bool HasWiFi);

        Oven CreateOven(decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string ElectricOrGas);

        Refrigerator CreateRefrigerator(decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string TypeOfTechnology);

        WashingMachine CreateWashingMachine(decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string LaundryCapacity, string MotorType);
    }
}
