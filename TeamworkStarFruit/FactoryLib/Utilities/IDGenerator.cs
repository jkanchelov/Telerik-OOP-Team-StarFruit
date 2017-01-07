using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryLib.Utilities
{
    public class IDGenerator
    {
        private int id;

        public IDGenerator()
        {
            this.id = 0;
        }
        public int GenerateID()
        {
            return Interlocked.Increment(ref this.id);
        }
    }
}
