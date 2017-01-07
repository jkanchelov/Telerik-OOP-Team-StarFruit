using FactoryLib.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLib
{
    public class Factory : IMobileFactory, IBigAppliancesFactory, IComputerFactory, ISmallAppliancesFactory
    {
        // TO DO
        private readonly IDGenerator generator;
        public Factory(IDGenerator generator)
        {
            this.generator = generator;
        }
    }
}
