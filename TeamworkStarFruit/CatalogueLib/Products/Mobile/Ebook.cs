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
        public EBook(bool isAvailable, Brand brand) : base(isAvailable, brand)
        {
        }

        public string Brand
        { get; private set; }

        public string Model
        { get; private set; }

        public double DisplaySize
        { get; private set; }

        public int Memory
        { get; private set; }

        public double CPU
        { get; private set; }

        public int Price
        { get; private set; }
    }
}
