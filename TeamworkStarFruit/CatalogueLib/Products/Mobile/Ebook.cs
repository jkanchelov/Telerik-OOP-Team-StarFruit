using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    public class EBook : Mobile
    {
        public EBook(int ID, decimal price, bool isAvailable, Brand brand) : base(ID, price, isAvailable, brand)
        {
        }

        public string Model
        { get; private set; }

        public int Memory
        { get; private set; }

        public string SupportedFileFormats
        { get; private set; }


        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Model: {this.Model}\nMemory:{this.Memory}\nScreen Size: {this.ScreenSize}\nSupported file formats: {this.SupportedFileFormats}\nConnectivity: {this.Connectivity}";
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}
