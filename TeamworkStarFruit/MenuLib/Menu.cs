using System;

namespace MenuLib
{
    public class Menu
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("----------------- MENU -----------------");
            Console.WriteLine("(1) --> Show all products in catalogue.");
            Console.WriteLine("(2) --> Show products in a group.");
            Console.WriteLine("(3) --> Add a product to your bag.");
            Console.WriteLine("(4) --> Remove product from your bag.");
            Console.WriteLine("(5) --> Show products in your bag.");
            Console.WriteLine("(6) --> Pay.");
            Console.WriteLine("(7) --> Add product to catalogue.");
            Console.WriteLine("(8) --> Remove product from catalogue.");
            Console.WriteLine("(9) --> Exit.");
        }

        public static void GroupProductsMenu()
        {
            Console.WriteLine("----------------- MENU -----------------");
            Console.WriteLine("(1) --> Show Big Appliances.");
            Console.WriteLine("(2) --> Show Small Appliances.");
            Console.WriteLine("(3) --> Show Mobiles.");
            Console.WriteLine("(4) --> Show Computers.");
        }

        public static void AddProductMenu()
        {
            Console.WriteLine("What kind of product you want to add?");
            // TO DO
        }
    }
}
