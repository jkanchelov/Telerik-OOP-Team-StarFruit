using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class Computer : Product
    {
        public Computer(decimal price, bool isAvailable, Brand brand)
            :base(price,isAvailable, brand)
        {

        }

        public string CPU
        { get; private set; }

        public int DriveMemory //in megabytes
        { get; private set; }

        public string VideoCardModel
        { get; private set; }

        public string OperationSystem
        { get; private set; }

        public double ScreenSize //in inches
        { get; private set; }

        public int RAM //in gigs
        { get; private set; }

        public override string ToString()
        {

            if (this.isAvailable)
            {
                return $"Brand: {this.brand}\nCPU:{this.CPU}\nDrive Memory:{this.DriveMemory} megabytes\nVideo Card:{this.VideoCardModel}\nOperation System:{this.OperationSystem}\nScreen size:{this.ScreenSize} inches\nRAM:{this.RAM}";
            }
            else
            {
                return $"The selected product is not available at the moment.";
            }

        }

    }
}
