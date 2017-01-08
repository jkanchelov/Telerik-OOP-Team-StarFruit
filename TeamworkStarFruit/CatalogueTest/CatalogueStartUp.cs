using System;
using CatalogueLib;
using MenuLib;
using BagLib;
//using FactoryLib;
//using FactoryLib.Utilities;

namespace CatalogueTest
{
    class CatalogueStartUp
    {
        private const string adminPass = "starfruits";

        static void Main(string[] args)
        {

            Menu m = new Menu();
            Menu.CreateMenu();
            Menu.ShowMenu("1");
            m.Navigate();
        }
    }
}
