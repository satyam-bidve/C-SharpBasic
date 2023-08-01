using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1.Abstract
{
    interface human
    {
        void work();
    }

    // if abstact class is not public then it will give error CS0060 class is less accessibel
     public abstract class Person :human // This is an abstract class .. it can be inherite interface 
    {
        public abstract void DoWork();// method is abstract so it cant have body 
                                      // the same method can have diffrent implementation for diff class 
                                      // thats why we use abstarct method and class 
        void human.work()
        {
            throw new NotImplementedException();
        }
       
    }

    public class Student : Person
    {
        public override void DoWork()
        {
            Console.WriteLine("Working on class project");
        }
    }

    public class Employee : Person
    {
        public override void DoWork()
        {
            Console.WriteLine("Working on Company project");
        }
    }

    internal class AbstractClassEx
    {
        public void AbstactionEX()
        {
            Console.Clear();
            Console.WriteLine("-------------------------ABSTRACTION---------------------------");
            Console.WriteLine("The abstract keyword enables you to create classes and class members that are incomplete " +
                "and must be implemented in a derived class.\n");
            Console.WriteLine("------------------------ OutPut -----------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**** there is no such visible output check the code itself****");
           
        }

    }
}
