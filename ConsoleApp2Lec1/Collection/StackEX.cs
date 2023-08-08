using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1.Collection
{
    internal class StackEX
    {
        public void StackEx() 
        {
            Console.Clear();
            Console.WriteLine("------------------------ Stack ------------------");
            Console.WriteLine("\t Store data in a such form that last instert element will be the first come out LIFO - last in first Out manner\n");
            Console.WriteLine("\t Stack are of two types Generic and non-generic, Can Contain duplicated and just values store insersation order in last to first");
            Console.WriteLine("------------------------ OutPut -----------------------");

            // Generic Stack
            Stack<int> stackNumbers = new Stack<int>(); 
            stackNumbers.Push(65);
            stackNumbers.Push(41);
            stackNumbers.Push(98);
            stackNumbers.Push(43);
            stackNumbers.Push(14);
            stackNumbers.Push(14);
            stackNumbers.Push(7);

            // printing stack 
            foreach (int i in stackNumbers)
            {
                Console.WriteLine(i); // 7,14,14,43,98,41,65
            }

            stackNumbers.Pop(); // remove last inserted ele -> 7 
            
        }
    }
}
