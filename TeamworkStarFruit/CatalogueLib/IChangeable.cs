using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueLib
{
    public interface IChangeable
    {
        void AddProduct(Product product);
        void RemoveProduct(int id);
        void RemoveAll();
    }
}
