using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueLib.Products.Struct
{
    public struct Battery
    {
        public string Model { get; set; }

        public int mAh { get; set; }

        public int HoursIdle { get; set; }

    }
}
