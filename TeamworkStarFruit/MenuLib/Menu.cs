namespace MenuLib
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    using CatalogueLib;
    using CatalogueLib.Products;

    public class Menu
    {
        public static Dictionary<string, string> menuPages = new Dictionary<string, string>();
        public static List<Product> list = new List<Product>();
        private const string adminPass = "starfruits";
        // TO DO add menu pages
        public static void CreateMenu()
        {
            //Catalogue pc = new Catalogue();
            //list = pc.Initialcatalog();
            //think about using only one obj of StringBuilder to pass the values to a dictionary 
            //or make objects for all categories
          
            menuPages.Add("1", "(1) --> Enter like admin.\n(2) --> Enter like customer.\n(3) --> Exit.");
            //admin
            menuPages.Add("11", "(1) --> Show categories.\n(2) --> Back.");
            menuPages
                .Add("111",
                "(1) --> Show Big Appliances.\n(2) --> Show Small Appliances.\n(3) --> Show Mobiles.\n(4) --> Show Computers.\n(5) --> Back");

            //customer
            menuPages.Add("12", "(1) --> Show categories.\n(2) --> Show your bag.\n(3) --> Back.");
            menuPages.Add("121", "(1) --> Show Big Appliances.\n(2) --> Show Small Appliances.\n(3) --> Show Mobiles.\n(4) --> Show Computers.\n(5) --> Back");
            //the product pages
            //need method to chek the id if it exist add it to bag.

            //Big Apl
            menuPages.Add("1211", "----- Big Appliances ------\n" +
                "(1) --> Air Conditioners\n(2) --> Ovens\n(3) --> Refrigerators\n" +
                "(4) --> Washing Machines\n(5) --> Show bag.\n(6) --> Back.");

            menuPages.Add("12111", "----- Air Conditioners ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("12112", "----- Ovens ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("12113", "----- Refrigerators ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("12114", "----- Washing Machines ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");


            //small Apl
            menuPages.Add("1212", "----- small Appliances ------\n(1) --> Hair Dryers\n(2) --> Mixers\n(3) --> Vacuum Cleaners(4)\n --> Show bag.\n(5) --> Back.");
            menuPages.Add("12121", "----- Hair Dryers ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("12122", "----- Mixers ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("12123", "----- Vacuum Cleaners ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");

            //Mobiles
            menuPages.Add("1213", "----- Mobiles ------\n" 
               + "(1) --> Ebooks\n(2) -->Mobile phones\n(3) --> Smart watches\n(4) --> Tablets\n(5) --> Show bag.\n(6) --> Back.");
            menuPages.Add("12131", "----- Ebooks ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("12132", "----- Mobile phones ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("12133", "----- Smart watches ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("12134", "----- Tablets ------\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");

            //Computers
            menuPages.Add("1214", "----- Computers ------\n(1) --> Desktops\n(2) --> Laptops\n(3) --> Show bag\n(4) --> Back.");
            menuPages.Add("12141", "----- Desktops -----\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");
            menuPages.Add("12142", "----- Laptops -----\n(1) --> Add to bag by ID\n(2) --> Show bag.\n(3) --> Back.");




            

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
            string key = "1";
            string option = ""; 
            int bound = 0;
            while (true)
            {
                option = Console.ReadLine();

                if(option == "")
                {
                    return;
                }

                switch (key)
                {
                    //admin 
                    case "1": bound = 3; break;
                    case "11": bound = 2; break;
                    case "111": bound = 5; break;
                    
                        //customer
                    case "12": bound = 3; break;
                    case "121": bound = 5; break;
                        //products list
                    //big apl
                    case "1211": bound = 6; break;
                    case "12111": bound = 3; break;
                    case "12112": bound = 3; break;
                    case "12113": bound = 3; break;
                    case "12114": bound = 3; break;

                    //small Apl
                    case "1212": bound = 5; break;
                    case "12121": bound = 3;break;
                    case "12122": bound = 3; break;
                    case "12123": bound = 3; break;

                    //mobiles
                    case "1213": bound = 6; break;
                    case "12131": bound = 3; break;
                    case "12132": bound = 3; break;
                    case "12133": bound = 3; break;
                    case "12134": bound = 3; break;

                    //computers
                    case "1214": bound = 4; break;
                    case "12141": bound = 3; break;
                    case "12142": bound = 3; break;

                        //TO DO
                        //1)add to bag

                        //2) Show bag.

                }


                if (option.Length > 1)
                {
                    Console.WriteLine("plese use the numbers in the brackets");
                    continue;
                }
                else 
                if (!(Convert.ToChar(option) - '0' >= 0 && Convert.ToChar(option) - '0' <= bound))
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

                    if (key == "11")
                    {
                        key = CheckPassword(key);
                        Menu.ShowMenu(key);
                    }
                    //customers nodes

                    //Air condition
                    else if (key == "12111")
                    {
                        Menu.ShowMenu(key);
                        AirConditioner ac = new AirConditioner();
                        PrintProduct(ac);
                    }
                    //oven
                    else if (key == "12112")
                    {
                        Menu.ShowMenu(key);
                        Oven ov = new Oven();
                        PrintProduct(ov);
                    }
                    //refrigerator
                    else if (key == "12113")
                    {
                        Menu.ShowMenu(key);
                        Refrigerator re = new Refrigerator();
                        PrintProduct(re);
                    }
                    //washing machine
                    else if (key == "12114")
                    {
                        Menu.ShowMenu(key);
                        WashingMachine wm = new WashingMachine();
                        PrintProduct(wm);
                    }
                    //else if (key == "1212")
                    //{
                    //    //small apl
                    //    Menu.ShowMenu(key);
                    //    Console.WriteLine("small apl collection .. .");

                    //}
                    //ebook
                    else if (key == "12131")
                    {
                        Menu.ShowMenu(key);
                        EBook eb = new EBook();
                        PrintProduct(eb);
                    }
                    //mobile phone
                    else if (key == "12132")
                    {
                        Menu.ShowMenu(key);
                        MobilePhone mp = new MobilePhone();
                        PrintProduct(mp);
                    }
                    //smart watch
                    else if (key == "12133")
                    {
                        Menu.ShowMenu(key);
                        SmartWatch sw = new SmartWatch();
                        PrintProduct(sw);
                    }
                    //tablets
                    else if (key == "12134")
                    {
                        Menu.ShowMenu(key);
                        Tablet tab = new Tablet();
                        PrintProduct(tab);
                    }
                    //small apl
                    //hair dryer
                    else if (key == "12121")
                    {
                        Menu.ShowMenu(key);
                        HairDryer hd = new HairDryer();
                        PrintProduct(hd);
                    }
                    //mixer
                    else if (key == "12122")
                    {
                        Menu.ShowMenu(key);
                        Mixer mix = new Mixer();
                        PrintProduct(mix);
                    }
                    //vacuum cleaner
                    else if (key == "12123")
                    {
                        Menu.ShowMenu(key);
                        VacuumCleaner vc = new VacuumCleaner();
                        PrintProduct(vc);
                    }

                    //Desktop key
                    else if (key == "12141")
                    {
                        Menu.ShowMenu(key);
                        Desktop desk = new Desktop();
                        PrintProduct(desk);
                    }
                    //Laptop key
                    else if (key == "12142")
                    {
                        Menu.ShowMenu(key);
                        Laptop lap = new Laptop();
                        PrintProduct(lap);
                    }

                    else
                    {
                        Menu.ShowMenu(key);
                    }
                }
            }
        }


        private string CheckPassword(string key)
        {
            Console.Clear();
            Console.Write("Password:");
            string pass = Console.ReadLine();
            if (pass != adminPass)
            {
                Console.WriteLine("Wrong password. Press any key to continue.\nFrom the previous menu.");
                Console.ReadKey();

                key = "1";
            }

            return key;
        }

        private static void PrintProduct(Product p)
        {
            Catalogue cat = new Catalogue();
            var list = cat.Show(p);
            foreach (var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine("===========================================");
            }
        }
       
    }
}
