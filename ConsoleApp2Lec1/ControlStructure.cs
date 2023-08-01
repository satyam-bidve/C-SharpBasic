using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1
{
    /* there are many ways to control the flow of program like by control statements and loops */
    internal class ControlStructure
    {
        // Method for multiple if else --- student marksheet 
        public void ifElseEx()
        {
            Console.Clear();
            Console.WriteLine("                          ---------------Control Statements-------------");
            // getting student marks and on that basis rank him A=75-100 B=55-75 C=35-55
            Console.WriteLine("Enter your marks here :");
            int marks = Convert.ToInt32(Console.ReadLine());
            if(marks >= 75 && marks < 101)
            {
                Console.WriteLine("great you got A in test :)");
            }
            else if(marks >=55 &&  marks < 75)
            {
                Console.WriteLine("good you got B in test :)");
            }
            else if(marks >=35 && marks <= 55 )
            {
                Console.WriteLine("good you got c in test :)");
            }
            else { Console.WriteLine("Study hard "); }

        }

        // for loop example 
        public void ForLoopEx()
        {
            Console.Clear();
            Console.WriteLine("                          ---------------Control Statements-  FOR LOOP------------");
            Console.WriteLine("\t \t A for loop is more flexible to work with , it has the ability to madify the sppeing / itration according to the " +
                "\t \t developer , it has three componants initialisation , codition checking and modification in index \n");
            Console.WriteLine("------------------------ OutPut -----------------------");
            //  printing multiplication table by choice of user 
            Console.WriteLine("Enter the number you want to pring that table ");
            int number = Convert.ToInt32(Console.ReadLine());
            // this loop is use when to work in indexing , to travel in reverse etc
            for(int i = 0; i <=10 ; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",number,i,number*i);
            }
        }

        // for each loop example 
        public void ForEachEx()
        {
            Console.Clear();
            Console.WriteLine("                     ---------------Control Statements ( For Each )-------------");
            Console.WriteLine("A foreach loop is a standard loop structure used in programming that allows you to iterate through the elements of a collection.");
            Console.WriteLine("------------------------ OutPut -----------------------");
            // for each is use to iterate data stucture like arrays lists and
            // more  so create first one array
            string[] cars = { "BMW M5", "Ford GT", "TaTA siara ", "toyota Supra" , "nisaan GTR" };
            // iterate through each element in array and prints it
            foreach (string car in cars)
            {
                Console.WriteLine("{0}", car);
            }

        }
        
    }
}
