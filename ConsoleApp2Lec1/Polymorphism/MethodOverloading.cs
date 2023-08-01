using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1.Polymorphism
{
    internal class MethodOverloading
    {

        // Method overloading means one method with same name can be write multiple times
        // in a same class but it must have different signature ie parameters veriation

        public static void menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=============== Polymorphism  =================");
            Console.WriteLine(">>>>>>>>>> 1. Method Overloading ");
            Console.WriteLine(">>>>>>>>>> 2. Method Overriding ");


            Console.ResetColor();

        }

        public static void UserChoice()
        {
            //   creating objects of related class here ....
            Overriding overriding = new Overriding();   
            Console.WriteLine("Choose options form above ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    tryOverLoading();
                    break;
                case 2:
                    overriding.OverridingEx();
                    break;



            }

        }
        public static int Add(int a, int b, int c) 
        {
            return a + b + c;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void tryOverLoading()
        {
            Console.Clear();
            Console.WriteLine("Two or more than two methods having the same name but different parameters is what we call function overloading in C#. " +
                "function overloading in C# can be performed by changing the number of arguments and the data " +
                "type of the arguments.\n");
            Console.WriteLine("------------------------ OutPut -----------------------");
            Console.WriteLine($"this is the result from method add having three para {Add(10, 20, 50)}\n"); ; // base on paramets match to method that method will be call 
            Console.WriteLine($"this is the result from method add having two para {Add(10, 20)}");

        }

        public  void MethodOverloadingEx() 
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
