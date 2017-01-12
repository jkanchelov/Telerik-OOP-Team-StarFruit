using FactoryLib.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products;
using CatalogueLib.Products.Enumerations;

namespace FactoryLib
{
    public class Factory : IMobileFactory, IBigAppliancesFactory, IComputerFactory, ISmallAppliancesFactory
    {
        private readonly IDGenerator generator;
        public Factory(IDGenerator generator)
        {
            this.generator = generator;
        }

        public Desktop CreateDesktop(decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string operationSystem, double ScreenSize, int RAM, bool HasDVDRecorder)
        {
            return new Desktop(price, isAvailable, brand, CPU,DriveMemory, VideoCardModel, operationSystem, ScreenSize, RAM, HasDVDRecorder);
        }

        public HairDryer CreateHairDryer(decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, int DifferentSpeeds)
        {
            return new HairDryer(price, isAvailable, brand, Capacity, CableLength, Affixes, DifferentSpeeds);
        }

        public Laptop CreateLaptop(decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string OperationSystem, double ScreenSize, int RAM, int HowManyUSBPorts)
        {
            return new Laptop(price, isAvailable, brand, CPU, DriveMemory, VideoCardModel, OperationSystem, ScreenSize, RAM, HowManyUSBPorts);
        }

        public Mixer CreateMixer(decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, bool HasBowl)
        {
            return new Mixer(price, isAvailable, brand, Capacity, CableLength, Affixes, HasBowl);
        }

        public VacuumCleaner CreateVacuumCleaner(decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, double GarbageBagVolume)
        {
            return new VacuumCleaner(price, isAvailable, brand, Capacity, CableLength, Affixes, GarbageBagVolume);
        }
    }
}
