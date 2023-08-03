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

            Console.ResetColor();
        }

        public static void TakeInOpration()
        {
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
    }
}
