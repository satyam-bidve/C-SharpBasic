using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1
{
    internal class ParametersPassing
    {
        //==============================================================================================================
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("===============  Parameter Passing Techniques =================");
            Console.WriteLine(">>>>>>>>>> 1. pass by value");
            Console.WriteLine(">>>>>>>>>> 2. pass By referance");
            Console.WriteLine(">>>>>>>>>> 3. Call By REF OUT");
        }

        public static void UserChoice()
        {
            Console.WriteLine("Choose options form above ");
            int choice = int.Parse(Console.ReadLine()); 
            switch (choice)
            {
                case 1:
                    CallByValue();
                    break; 
                case 2:
                    CallByRef();
                    break;
                case 3:
                    CallByRefOut();
                    break;

            }
        
        }
        //================================================================================================================== Write Your functions below this 


        //Call By value Exaple 

        public static void CallByValue()
        {
            Console.Clear();
            Console.WriteLine("CALL BY VALUE =   In call by value after making " +
                "modification in function the original value does not change \n " +
                "becouse the new copy is sent to the function \n");
            Console.WriteLine("Enter the value to pass the function \n");
            int MainValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"before the modification {MainValue} ");
            TochangeValue( MainValue );
            Console.WriteLine($"After the modification {MainValue} ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("So the value after oprating in function not change ");
            Console.ResetColor();


            int TochangeValue (int number)
            {
                number = number * 2;
                Console.WriteLine($"in the fuction taking value : {number}");
                return number;
            }

            
            
        }

        // CALL BY REF
        public static void CallByRef()
        {
            Console.Clear();
            Console.WriteLine("CALL BY REF =   In call by REF after making modification" +
                " in function the original value  change \n"+"Here we pass value as well " +
                "as the memory address of that veraiable \n");
            Console.WriteLine("Enter the value to pass the function \n");
            int MainValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"before the modification {MainValue} ");
            TochangeValue(ref MainValue);
            Console.WriteLine($"After the modification {MainValue} ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("So the value after oprating in function is  change ");
            Console.ResetColor();


            int TochangeValue( ref int number)
            {
                number = number * 2;
                Console.WriteLine($"in the fuction taking value : {number}");
                return number;
            }



        }


        // OUT - CALL BY REF
        public static void CallByRefOut()
        {
            Console.Clear();
            Console.WriteLine("CALL BY REF OUT  =   In call by REF OUT  after making modification in function the original value not be considerd " +
                "becouse we need to initialise the veriable in fuction  \n");
            Console.WriteLine("Enter the value to pass the function \n");
            int MainValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"before the modification {MainValue} ");
            TochangeValue( out MainValue);
            Console.WriteLine($"After the modification {MainValue} ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Does not matter what value you provide to fuction , its only one way  ");
            Console.ResetColor();


            int TochangeValue( out int number)
            {
                number = 5;  // need to initinalise the veribale here its only one way 
                number = number * 2;
                Console.WriteLine($"in the fuction taking value : {number}");
                return number;
            }



        }

        //--------------------------------------------------------------------------------------------------------------------
        public void ParametersPassingEx()
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

        }//---------------------------------------------------------------------------------------------------------------------------------
    }
}
