using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib;
using MenuLib;
using BagLib;


namespace CatalogueTest
{
    class Program
    {
        public const string adminPass = "starfruits";

        static void Main(string[] args)
        {
            Catalogue myCatalogue = new Catalogue();
            Bag myBag = new Bag();
            Menu.ShowMainMenu();
            string choise;
            do
            {
                do
                {
                    choise = Console.ReadLine();
                }
                while (choise != "1" && choise != "2" && choise != "3" && choise != "4" && choise != "5" && choise != "6" && choise != "7" && choise != "8" && choise != "9");

                if (choise == "1")
                {
                    myCatalogue.ShowAll();
                }
                else if (choise == "2")
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
                        case "5": myCatalogue.ShowPrinters(); break;
                    }
                }
                else if (choise == "3")
                {
                    //TO DO
                }
                else if(choise == "4")
                {
                    Console.WriteLine("Enter ID of product you want to remove:");
                    int id = int.Parse(Console.ReadLine());
                    myBag.RemoveProduct(id);
                }
                else if(choise == "5")
                {
                    myBag.RemoveAll();
                }
                else if(choise == "6")
                {
                    Console.WriteLine(myBag);
                }
                else if (choise == "7")
                {
                    Console.WriteLine("Enter password:");
                    string pass = Console.ReadLine();
                    if (pass != adminPass)
                    {
                        throw new Exception("Invalid password");
                    }
                    else
                    {
                        //TO DO
                    }

                }
                else if (choise == "8")
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
                Menu.ShowMainMenu();
            } while (choise != "9");

            if (choise == "9")
            {
                Environment.Exit(0);
            }
        }
    }
}
