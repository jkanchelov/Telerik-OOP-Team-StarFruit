using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib;
using CatalogueLib.Products;
using CatalogueLib.Products.Enumerations;

namespace FactoryLib
{
    public interface IComputerFactory
    {
        Laptop CreateLaptop(decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string OperationSystem, double ScreenSize, int RAM, int HowManyUSBPorts);

        Desktop CreateDesktop(decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string OperationSystem, double ScreenSize, int RAM, bool HasDVDRecorder);
    }
}
