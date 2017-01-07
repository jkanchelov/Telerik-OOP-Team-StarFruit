using System;
using CatalogueLib;
using MenuLib;
using BagLib;
using FactoryLib;
using FactoryLib.Utilities;

namespace CatalogueTest
{
    class CatalogueStartUp
    {
        private const string adminPass = "starfruits";

        static void Main(string[] args)
        {
            Catalogue myCatalogue = new Catalogue();
            Bag myBag = new Bag();
            Factory myFactory = new Factory(new IDGenerator());
            Start(myCatalogue, myBag, myFactory);
        }

        public static void Start(Catalogue myCatalogue, Bag myBag, Factory myFactory)
        {
            Menu.ShowMainMenu();
            string choise;
            do
            {
                do
                {
                    choise = Console.ReadLine();
                }
                while (choise != "1" && choise != "2" && choise != "3" && choise != "4" && choise != "5" && choise != "6" && choise != "7" && choise != "8" && choise != "9");

                switch (choise)
                {
                    case "1": myCatalogue.ShowAll();break;
                    case "2": ShowProductsInAGroup(myCatalogue); break;
                    case "3": ShowProductsInAGroup(myCatalogue); break;
                    case "4": RemoveProductFromBag(myBag); break;
                    case "5": myBag.RemoveAll(); break;
                    case "6": Console.WriteLine(myBag); break;
                    case "7": AddProductToCatalogue(myCatalogue); break;
                    case "8": RemoveProductFromCatalogue(myCatalogue); break;
                    default:
                        break;
                }
                Menu.ShowMainMenu();
            } while (choise != "9");

            if (choise == "9")
            {
                Environment.Exit(0);
            }
        }

        private static void ShowProductsInAGroup(Catalogue myCatalogue)
        {
            Menu.GroupProductsMenu();
            string groupChoise;

            do
            {
                groupChoise = Console.ReadLine();
            } while (groupChoise != "1" && groupChoise != "2" && groupChoise != "3" && groupChoise != "4" && groupChoise != "5");

            switch (groupChoise)
            {
                case "1": myCatalogue.ShowBigAppliances(); break;
                case "2": myCatalogue.ShowSmallAppliances(); break;
                case "3": myCatalogue.ShowMobiles(); break;
                case "4": myCatalogue.ShowComputers(); break;
            }
        }

        private static void RemoveProductFromBag(Bag myBag)
        {
            Console.WriteLine("Enter ID of product you want to remove:");
            int id = int.Parse(Console.ReadLine());
            myBag.RemoveProduct(id);
        }

        private static void RemoveProductFromCatalogue(Catalogue myCatalogue)
        {
            Console.WriteLine("Enter password:");
            string pass = Console.ReadLine();
            if (pass != adminPass)
            {
                throw new Exception("Invalid password");
            }
            else
            {
                Console.WriteLine("Enter ID of product you want to remove:");
                int id = int.Parse(Console.ReadLine());
                myCatalogue.RemoveProduct(id);
            }
        }

        private static void AddProductToCatalogue(Catalogue myCatalogue)
        {
            Console.WriteLine("Enter password:");
            string pass = Console.ReadLine();
            if (pass != adminPass)
            {
                throw new Exception("Invalid password");
            }
            else
            {
                // TO DO
            }
        }
    }
}
