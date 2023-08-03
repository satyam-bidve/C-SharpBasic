using System;
using System.Runtime.CompilerServices;
using ConsoleApp2Lec1.Polymorphism;
using ConsoleApp2Lec1.AccessModifiers;
using ConsoleApp2Lec1.Constuctor;
using ConsoleApp2Lec1.Interface;
using ConsoleApp2Lec1.Abstract;
using ConsoleApp2Lec1.Extension_Method;
using ConsoleApp2Lec1.Collection;


namespace ConsoleApp2Lec1
{
    internal class Program
    {
        


        // Showing menu to user which options they have to choose from  ---------🤟
        static void Showmenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------MENU------------");
            Console.WriteLine("1 - age validation");
            Console.WriteLine("2 - addition");
            Console.WriteLine("3 - multiplication");
            Console.WriteLine("4 - substraction");
            Console.WriteLine("5 - Control [if else] student Makrsheet ");
            Console.WriteLine("6 - for-loop to print table ");
            Console.WriteLine("7 - forEach to prints fev cars ");
            Console.WriteLine("8 - Array [Chapter]");
            Console.WriteLine("9 - Parameter Passing");
            Console.WriteLine("10 - Enum and Structure");
            Console.WriteLine("11 - Inheritance ");
            Console.WriteLine("12 - Polymorphism ");
            // Console.WriteLine("13 - (Access mod , Constructor , Interface , Abstract) go to code no visible output");
            Console.WriteLine("12 - Access Modifires ");
            Console.WriteLine("14 - Constuctor ");
            Console.WriteLine("15 - Interface ");
            Console.WriteLine("16 - Absraction ");
            Console.WriteLine("17 - Extention Methods ");
            Console.WriteLine("18 - Collections  [Chapter]");
            Console.ResetColor();
        }

        // This is the method to add more functionality  to project its only --method calling in switch case  -------👇
        static void TakingOptionAndOpration()

        {
            CollectionEX collectionEXOBJ = new CollectionEX();
            UseOfExtensionMethods useOfExtensionMethods = new UseOfExtensionMethods();
            AbstractClassEx abstractClassEx = new AbstractClassEx();
            testClass testClassInterface = new testClass();
            CallConstructor callConstructor = new CallConstructor();
            AccessModiPro accessModiPro = new AccessModiPro();
            MethodOverloading polymorphismObj = new MethodOverloading();
            Inheritance inheritanceObj = new Inheritance();
            EnumAndStructure EnumAndStuctObj = new EnumAndStructure();
            ControlStructure controlObj = new ControlStructure(); // class refrance to use methods from that class
            ArrayStucture ArrayObj = new ArrayStucture(); // Array Stucture object to call methods
            ParametersPassing paraObj = new ParametersPassing();


            Console.WriteLine("Please choose one of option from menu");
           
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    ageValidation();
                    break;
                case 2:
                    addition();
                    break;
                case 3:
                    multiplication();
                    break;
                case 4:
                    substraction();
                    break;
                case 5:
                    
                    controlObj.ifElseEx();
                    break;
                case 6:
                    controlObj.ForLoopEx();
                    break;
                case 7:
                    controlObj.ForEachEx();
                    break;
                case 8:
                   ArrayObj.ArrayStucExamples();
                    break;
                case 9:
                    paraObj.ParametersPassingEx();
                    break;
                case 10:
                    EnumAndStuctObj.EnumAndStructureEX();
                    break;
                case 11:
                    inheritanceObj.InheritanceEX();
                    break;
                case 12:
                    polymorphismObj.MethodOverloadingEx(); // name here is overloading but its entry for poly
                    break;
                case 13:
                    accessModiPro.AccessInMainEx();
                    break;
                case 14:
                    callConstructor.TestConstuctor();
                    break;
                case 15:
                    testClassInterface.InterfaceInfo();
                    break;
                case 16:
                    abstractClassEx.AbstactionEX();
                    break;
                case 17:
                    useOfExtensionMethods.useOfExtention();
                    break;
                case 18:
                    collectionEXOBJ.CollectionEx();
                    break;




            }

        }

        // from here on actully adding functaionality to propgram ---------- happy coding 😁
        static void addition()
        {
            Console.Clear();
            Console.WriteLine("                          ---------------Arithmatic Opration-------------");
            Console.WriteLine("Enter number 1 :");
            int number1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter number 2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = number1 + number2;
            Console.WriteLine("The addition of {0} and {1} is  = {2}",number1,number2,result);

        }
        static void multiplication()
        {
            Console.Clear();
            Console.WriteLine("                          ---------------Arithmatic Opration-------------");
            Console.WriteLine(" Enter number 1 :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int resultOfMulti = number1 * number2;
            Console.WriteLine("  The multiplication of {0} and {1} is  = {2}", number1, number2, resultOfMulti);

        }
        static void substraction()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                          ---------------Arithmatic Opration-------------");
            Console.WriteLine("Enter number 1 :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int resultOfSub = number1 - number2;
            Console.WriteLine(" The substraction of {0} and {1} is  = {2}", number1, number2, resultOfSub);

        }
        static void ageValidation()
        {
            Console.Clear();
            Console.WriteLine("This is the sample implementation of control statement (if else )");
            Console.WriteLine("------------------------ OutPut -----------------------");
            Console.WriteLine("Check for your voting age validation");
            Console.WriteLine("Enter your age here -> ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("you are eligibale to vote :)");


            }
            else
            {
                Console.WriteLine("No you are not eligibale !");
            }
            
        }

        // main method Entry point of project ----------🙂
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            // Running in a loop and asking for if they want to contineue ---
            Boolean wantRepeat = true;
            do {

               
                Showmenu();
                TakingOptionAndOpration();

                Console.WriteLine("Do you want to continue ? if yes Enter Y and if no then N  ");
                string reapeatChoice =  Console.ReadLine();
                if (reapeatChoice == "Y" || reapeatChoice == "y")
                {
                    Console.Clear();
                    wantRepeat = true;
                }
                else if (reapeatChoice == "N"|| reapeatChoice == "n")
                {
                    wantRepeat = false;
                    Console.Clear();
                    Console.WriteLine("Thanks for your time :)");
                }
            } 
            while (wantRepeat);




            

        }
    }
}
