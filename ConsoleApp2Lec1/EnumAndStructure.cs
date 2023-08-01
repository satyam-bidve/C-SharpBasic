using System;
using System.Collections.Generic;


namespace ConsoleApp2Lec1
{
    internal class EnumAndStructure
    {

        public static void menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===============  Enum And Stucture  =================");
            Console.WriteLine(">>>>>>>>>> 1. Enum Exaple ");
            Console.WriteLine(">>>>>>>>>> 2. Stuct Example ");

            Console.ResetColor();
            
        }

        public static void UserChoice()
        {
            Console.WriteLine("Choose options form above ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    EnumEx();
                    break;
                case 2:
                    StuctEx(); 
                    break;
            }

        }

        //===============================================================================================================================
        enum Speed
        {
            Supra,
           
            failady = 12,
           
            RTX = 15
          
        }
        public static void EnumEx()
        {
            Console.Clear();
            Console.WriteLine("-------------- Enum Exaple -----------");
            Console.WriteLine("\t \t \t An enum is a special \"class\" that represents a group of constants (unchangeable/read-only variables).To create an enum,\n" +
                " use the enum keyword (instead of class or interface), and separate the enum items with a comma:\n");

            // Enum can be use in two ways by its constat and by its name it is mainly to store realated constats to use them letter 
            if (Speed.Supra > Speed.failady) // Here no need to type cast the element to get its value 
            {
                Console.WriteLine("Supra is fast");
            }
            else if (Speed.failady > Speed.RTX)
            {
                Console.WriteLine("fairlady is fast");
            }
            else
            {
                Console.WriteLine("RTX is fast \n");
            }

            Console.WriteLine($"this is the name of our first enum elemet {Speed.failady}\n"); // it prints the only name of enum not its value 
            Console.WriteLine($"And the value whic is constat if that element is {(int)Speed.failady}\n");


        }

        struct Cars
        {
            private string model; // title 
            private string Brand; // auther
            private string make; // subject
           

            public void SetValues(string t, string a, string s)
            {
                model = t;
                Brand = a;
                make = s;
                
            }

            public void display()
            {
                Console.WriteLine("Title : {0}", model);
                Console.WriteLine("Author : {0}", Brand);
                Console.WriteLine("Subject : {0}", make);
                
            }
        };


        public static void StuctEx()
        {
            Console.Clear();
            Console.WriteLine("---------------- Stucture Exaple ---------------");
            Console.WriteLine("\t \t struct can be used to hold small data values that do not require inheritance, e.g. coordinate points, key-value pairs, and complex data structure\n");
            Console.WriteLine("\t \t It can contain a parameterized constructor, static constructor, constants, fields, methods, properties, indexers, operators, events, and nested types.\n");

            // here in this method we call methods which are in stuct above 

           

            Cars  mycar = new Cars();     // creating cars with type of car like object
            Cars  friendsCar = new Cars();

            

            // my car specification */
            mycar.SetValues("Muastang",
            "Ford", "1969");

           
            friendsCar.SetValues("GTR","nissan","1996");

            
            mycar.display();

           
            friendsCar.display();
        }



        //==============================================================================================================================


        public void EnumAndStructureEX() 
        {
            Boolean playAgian = true;

            do
            {


                menu();
                UserChoice();

                Console.WriteLine("Do you want to try another topics yes -> y and no -> n  ");
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
