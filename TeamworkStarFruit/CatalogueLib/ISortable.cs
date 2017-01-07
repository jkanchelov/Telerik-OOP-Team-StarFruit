using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueLib
{
    public interface ISortable
    {
        IEnumerable<Product> ShowBigAppliances();
        IEnumerable<Product> ShowSmallAppliances();
        IEnumerable<Product> ShowMobiles();
        IEnumerable<Product> ShowComputers();
        IEnumerable<Product> ShowPrinters();
        IEnumerable<Product> ShowAll();
    }
}
