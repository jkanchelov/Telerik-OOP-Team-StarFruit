using System;
using CatalogueLib;
using MenuLib;
using BagLib;


namespace CatalogueTest
{
    class CatalogueStartUp
    {
        public const string adminPass = "starfruits";

        static void Main(string[] args)
        {
            Menu m = new Menu();
            Menu.CreateMenu();
            Menu.ShowMenu("1");
            m.Navigate();
        }
    }
}
