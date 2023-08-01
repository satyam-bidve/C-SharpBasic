using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1.Polymorphism
{
    public class MethodOverriding // this will be the paraent class 
    {
        public virtual double Area()
        {
            return 0;
        }

        public virtual void message()
        {
            Console.WriteLine("This is the message from base class :)");
        }
    }
    public class Circle : MethodOverriding // first child class 
    {
        public double Radius = 6;
        public override double Area()
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
        public override void message()
        {
            base.message(); // this will call the method of base class base keyword 
            Console.WriteLine("This is message in child ^:");
        }
    }

    public class Squre : MethodOverriding
    {
        public double Length = 10;
        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }

    public class Overriding
    {
       
       public  void OverridingEx()
        {
            MethodOverriding circle = new Circle();
            Console.WriteLine("Circle Area: " + circle.Area());

            MethodOverriding square = new Squre();
            Console.WriteLine("Square Area: " + square.Area());

            Circle cirObj = new  Circle();
            cirObj.message();  // calling child class mesaage and iside it calling base class with base keyword 
        }
        

    }
}
