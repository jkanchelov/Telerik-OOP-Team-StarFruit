﻿using System;
using System.Text;
using System.Collections.Generic;

namespace MenuLib
{
    public class Menu
    {
        public static Dictionary<string, string> menuPages = new Dictionary<string, string>();
        // TO DO add menu pages
        public static void CreateMenu()
        {
            menuPages.Add("1", "(1) --> Enter like admin.\n(2) --> Enter like customer.\n(3) --> Exit.");
            menuPages.Add("11", "(1) --> Show categories.\n(2) --> Back.");
            menuPages
                .Add("111",
                "(1) --> Show Big Appliances.\n(2) --> Show Small Appliances.\n(3) --> Show Mobiles.\n(4) --> Show Computers.\n(5) --> Show Printers.\n(6) --> Back");

        }

        public static void ShowMenu(string key)
        {
            Console.Clear();
            Console.WriteLine("Press the symbol in the brakets to navigate the menu.");
            Console.WriteLine("-----------------------------------------------------");
            foreach (KeyValuePair<string, string> kvp in menuPages)
            {
                if (key == kvp.Key)
                {
                    Console.WriteLine(kvp.Value);
                }
            }
        }

        //TO Do Exception handling or go to the top of the loop if the input is bad
        //and print msg
        public void Navigate()
        {
<<<<<<< HEAD
            string key = "1";
            string option = ""; 
            int bound = 0;
            while (true)
            {
                option = Console.ReadLine();

                switch (key)
                {
                    case "1": bound = 3; break;
                    case "11": bound = 2; break;
                    case "111": bound = bound = 6; break;
                }


                if (option.Length > 1)
                {
                    Console.WriteLine("plese use the numbers in the brackets");
                    continue;
                }
                else if (!(Convert.ToChar(option) - '0' >= 0 && Convert.ToChar(option) - '0' <= bound))
                {
                    Console.WriteLine("Please use a digit which is in range between 1 and {0}", bound);
                    continue;
                }
                else if(Convert.ToInt32(option) <= bound)
                {
                    
                    if (Convert.ToInt32(option) == bound)
                    {
                        StringBuilder temp = new StringBuilder();
                        for (int i = 0; i < key.Length - 1; i++)
                        {
                            temp.Append(key[i]);
                        }
                        key = temp.ToString();
                        temp.Clear();
                    }
                    else
                    {
                        key = key + option.ToString();
                    }
                    Menu.ShowMenu(key);
                }
            }
=======
            Console.WriteLine("----------------- MENU -----------------");
            Console.WriteLine("(1) --> Show Big Appliances.");
            Console.WriteLine("(2) --> Show Small Appliances.");
            Console.WriteLine("(3) --> Show Mobiles.");
            Console.WriteLine("(4) --> Show Computers.");
>>>>>>> 6c720230c7602a5b0d7fed1aceaf1cf6c1da6ede
        }


        public static void AddProductMenu()
        {
            Console.WriteLine("What kind of product you want to add?");
            // TO DO
        }
    }
}
