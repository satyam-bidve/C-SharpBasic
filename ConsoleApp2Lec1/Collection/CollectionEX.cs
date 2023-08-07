using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1.Collection
{
    internal class CollectionEX
    {
        static void Showmenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------MENU OF Collection------------");
            Console.WriteLine(" >>> 1 - ArrayList");
            Console.WriteLine(" >>> 2 - List");
            Console.WriteLine(" >>> 3 - Dictionary");
            Console.WriteLine(" >>> 4 - HashTable ");


            Console.ResetColor();
        }

        public static void TakeInOpration()
        {
            HashTableEX hashTableObj = new HashTableEX();
            DictionaryEX dictionaryObj = new DictionaryEX();
            ListEX listObj = new ListEX();
            ArrayListEX ArrayListObj = new ArrayListEX();
            Console.WriteLine("Enter which topic you want to - visit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ArrayListObj.ArrayListEx();
                    break;
                case 2:
                    listObj.ListEx();
                    break;
                case 3:
                    dictionaryObj.DictionaryEx();
                    break;
                case 4:
                    hashTableObj.HashTableEx();
                    break;
            }
        }

        public void CollectionEx()
        {
            Boolean playAgian = true;

            do
            {


                Showmenu();
                TakeInOpration();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want to try another topics yes -> y and no -> n  ");
                Console.ResetColor();
                string playAgianChoice = Console.ReadLine();
                if (playAgianChoice == "Y" || playAgianChoice == "y")
                {
                    Console.Clear();
                    playAgian = true;
                }
                else if (playAgianChoice == "N" || playAgianChoice == "n")
                {
                    playAgian = false;
                    Console.Clear();
                    Console.WriteLine("Back to main menu");

                }
            }
            while (playAgian);
        }
        public  void InitialiseFarmers()
        {
            Farmers farmer1, farmer2, farmer3, farmer4, farmer5;
            GetfarmersRecord(out farmer1, out farmer2, out farmer3, out farmer4, out farmer5);
        }
        public static void GetfarmersRecord(out Farmers farmer1, out Farmers farmer2, out Farmers farmer3, out Farmers farmer4, out Farmers farmer5)
        {
            farmer1 =  new Farmers();
            farmer1.district = "nashik";
            farmer1.LandType = "arable";
            farmer1.LandSize = "45ARC";
            farmer1.name = "satyam";

            farmer2 = new Farmers();
            farmer2.district = "mumbai";
            farmer2.LandType = "hayfields";
            farmer2.LandSize = "63ARC";
            farmer2.name = "vijay";

            farmer3 = new Farmers();
            farmer3.district = "dhule";
            farmer3.LandType = "arable";
            farmer3.LandSize = "75ARC";
            farmer3.name = "sagar";

            farmer4 = new Farmers();
            farmer4.district = "nagar";
            farmer4.LandType = "hayfields";
            farmer4.LandSize = "58ARC";
            farmer4.name = "rohan";

            farmer5 = new Farmers();
            farmer5.district = "shirdi";
            farmer5.LandType = "arable";
            farmer5.LandSize = "37ARC";
            farmer5.name = "saurabh";

        }


    }
}
