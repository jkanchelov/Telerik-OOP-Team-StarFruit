using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionLib;

namespace CatalogueLib
{
    public class Catalogue : IChangeable, ISortable
    {
        public List<Product> catalogue { get; set; }
        public Catalogue()
        {
            this.catalogue = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            catalogue.Add(product);
        }

        public void RemoveProduct(int id)
        {
            bool hasBeenRemoved = false;
            foreach (var product in this.catalogue)
            {
                if (product.ID == id)
                {
                    catalogue.Remove(product);
                    hasBeenRemoved = true;
                    break;
                }
            }
            if (!hasBeenRemoved)
            {
                throw new ProductNotFoundException("There is not product with such an id.");
            }
        }

        public IEnumerable<Product> ShowAll()
        {
            return this.catalogue;
        }

        public IEnumerable<Product> ShowBigAppliances()
        {
            var bigAppliances = from product in this.catalogue
                                where product is BigAppliances
                                select product;
            return bigAppliances;
        }

        public IEnumerable<Product> ShowComputers()
        {
            var computers = from product in this.catalogue
                          where product is Computer
                          select product;
            return computers;
        }

        public IEnumerable<Product> ShowMobiles()
        {
            var mobiles = from product in this.catalogue
                                where product is Mobile
                                select product;
            return mobiles;
        }

        public IEnumerable<Product> ShowPrinters()
        {
            var printers = from product in this.catalogue
                          where product is Printer
                          select product;
            return printers; 
        }

        public IEnumerable<Product> ShowSmallAppliances()
        {
            var smallAppliances = from product in this.catalogue
                                  where product is SmallAppliances
                                  select product;
            return smallAppliances;
        }
    }
}
