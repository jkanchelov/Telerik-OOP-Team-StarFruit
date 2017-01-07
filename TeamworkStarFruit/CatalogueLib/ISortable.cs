using System.Collections.Generic;

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
