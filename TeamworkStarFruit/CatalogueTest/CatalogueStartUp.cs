using System;
using CatalogueLib;
using MenuLib;
using BagLib;
using FactoryLib;
using FactoryLib.Utilities;

namespace CatalogueTest
{
    public class CatalogueStartUp
    {
        static void Main()
        {

            Menu m = new Menu();
            Menu.CreateMenu();
            Menu.ShowMenu("1");
            m.Navigate();
        }
    }
}
