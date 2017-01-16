namespace CatalogueLib
{
    using System.Text;
    using CatalogueLib.Products.Enumerations;

    public abstract class Computer : Product
    {
        public Computer()
        {

        }
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

        public string CPU { get; private set; }

        //in megabytes
        public int DriveMemory { get; private set; }

        public string VideoCardModel { get; private set; }

        public string OperationSystem { get; private set; }

        //in inches
        public double ScreenSize { get; private set; }

        //in gigs
        public int RAM { get; private set; }

        public override string ToString()
        {
            StringBuilder stroitel = new StringBuilder();
            stroitel = stroitel.Append(string.Format("{0}", base.ToString()));
            stroitel = stroitel.Append(string.Format(" CPU: {0}\n Drive Memory: {1} megabytes\n Video Card: {2}\n Operation System: {3}\n Screen size: {4} inches\n RAM: {5}",this.CPU, this.DriveMemory, this.VideoCardModel, this.OperationSystem, this.ScreenSize, this.RAM));
            return stroitel.AppendLine().ToString();
        }

    }
}
