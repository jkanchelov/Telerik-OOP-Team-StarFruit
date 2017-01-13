using CatalogueLib.Products.Enumerations;

namespace CatalogueLib
{
    public abstract class Computer : Product
    {
        public Computer(int ID, decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string OperationSystem, double ScreenSize, int RAM)
            : base(ID, price, isAvailable, brand)
        {
            this.CPU = CPU;
            this.DriveMemory = DriveMemory;
            this.VideoCardModel = VideoCardModel;
            this.OperationSystem = OperationSystem;
            this.ScreenSize = ScreenSize;
            this.RAM = RAM;
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
            return base.ToString() + $"\nCPU:{this.CPU}\nDrive Memory:{this.DriveMemory} megabytes\nVideo Card:{this.VideoCardModel}\nOperation System:{this.OperationSystem}\nScreen size:{this.ScreenSize} inches\nRAM:{this.RAM}";
        }

    }
}
