using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    public class Desktop : Computer
    {
        public Desktop(int ID, decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string OperationSystem, double ScreenSize, int RAM, bool HasDVDRecorder)
            : base(ID, price, isAvailable, brand, CPU, DriveMemory, VideoCardModel, OperationSystem, ScreenSize, RAM)
        {
            this.HasDVDRecorder = HasDVDRecorder;
        }

        public bool HasDVDRecorder
        { get; private set; }

        public override string ToString()
        {
            if (this.isAvailable)
            {
                return $"Has DVD recorder: {this.HasDVDRecorder}";
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }
        }
    }
}
