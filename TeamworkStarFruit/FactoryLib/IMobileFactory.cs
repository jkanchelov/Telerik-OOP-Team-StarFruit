using CatalogueLib.Products;
using CatalogueLib.Products.Enumerations;
using CatalogueLib.Products.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLib
{
    public interface IMobileFactory
    {
        EBook CreateEbook(decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize, string SupportedFileFormat);

        Tablet CreateTablet(decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize, double FrontCamera, double BackCamera, bool HasGPS);

        MobilePhone CreateMobilePhone(decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize, string GPU, string OperatingSystem);

        SmartWatch CreateSmartWatch(decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize, double Size, bool WaterResistance);
    }
}
