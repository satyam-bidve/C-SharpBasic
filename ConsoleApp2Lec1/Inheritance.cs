using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1
{
    public class ParentClass
    {
        public ParentClass()  // constuctor of P
        {
            Console.WriteLine("Parent Constructor.");
        }
        public void print()
        {
            Console.WriteLine("I'm a Parent Class.");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() // Constyructor Of Child
        {
            Console.WriteLine("Child Constructor.");
        }
       
    }


    internal class Inheritance
    {
        public void  InheritanceEX()  // method to call in switch case 
        {

           
            Boolean playAgian = true;

            do
            {
                Console.Clear();
                Console.WriteLine("The capability of a class to derive properties and characteristics from another class is called Inheritance.");
                Console.WriteLine("Single Level Inheritance. Single Level Inheritance involves a single class inheriting from another class. .." +
                    ".\r\nHierarchical Inheritance. ..." +
                    "\r\nMulti-Level Inheritance. ..." +
                    "\r\nMultiple Inheritance Using Interfaces.");
                Console.WriteLine("------------------------ OutPut -----------------------");
                ChildClass child = new ChildClass();  // fist call parent constructor and then its own 
                child.print(); // on child object accesing the methods of parent class 

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
