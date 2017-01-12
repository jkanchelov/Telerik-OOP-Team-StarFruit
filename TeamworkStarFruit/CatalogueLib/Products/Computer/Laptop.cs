using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    public class Laptop : Computer
    {
        public Laptop(int ID, decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string OperationSystem, double ScreenSize, int RAM, int HowManyUSBPorts)
            : base(ID, price, isAvailable, brand, CPU, DriveMemory, VideoCardModel, OperationSystem, ScreenSize, RAM)
        {
            this.HowManyUSBPorts = HowManyUSBPorts;
        }
        public int HowManyUSBPorts
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Ammount of USB ports: {this.HowManyUSBPorts}";
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }

        }
    }
}
