using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1.Constuctor
{
    /* 
      use of constructors is to initialize the private fields of the class while creating an instance
     ----A class can have any number of constructors.
            A constructor doesn't have any return type, not even void.
            A static constructor can not be a parametrized constructor.
            Within a class, you can create one static constructor only. 
     */
    internal class ConstructorEx
    {
        /// <summary>
        /// When a constructor is created using a static keyword, it will be invoked only once for all of the
        /// instances of the class and it is invoked during the creation of the first instance of the class or the
        /// first reference to a static member in the class. A static constructor is used to initialize static fields 
        /// of the class and to write the code that needs to be executed only once.
        /// </summary>
        static ConstructorEx()
        {
            Console.WriteLine("IN a static Constructor Executes only ones :)");
        }

        //-0----------------------------------------------------------------
        public string name { get; set; } = "satyam";                        // fields for testing
        public string description { get; set; } = "dev";
        //-----------------------------------------------------------------------



        /// <summary>
        /// This is defult constructor call when object / instance is initialised  
        /// if not maintion it is automatically created by the compailer.
        /// </summary>
      public ConstructorEx() 
        {
            Console.WriteLine("default constructor called :)");


        }
        
        /// <summary>
        /// This is parametrrised Constuctor  we can create multiple parameteriesd constuctor with the help of method overloading
        /// </summary>
        /// <param name="name"></param>  // this is a parametred to pass in constuctor
        public ConstructorEx(string name) 
        {
            this.name = name;
        }

        /// <summary>
        ///   The constructor which creates an object by copying variables from another object is called a copy constructor. 
        ///   The purpose of a copy constructor is to initialize a new instance to the values of an existing instance.
        /// </summary>
        /// <param name="obj"></param>
        public ConstructorEx(ConstructorEx obj) 
        {
            this.name = obj.name;
            this.description = obj.description;
        }
    }

    public class CallConstructor
    {
        public void TestConstuctor()
        {
            ConstructorEx constObj = new ConstructorEx(); // this will call default constuctor 
            ConstructorEx constObj2 = new ConstructorEx("tatyaSaheb"); // this will call parameteriesd constructor 

            ConstructorEx ObjCopy = new ConstructorEx(constObj);  // copying the object of this to copy object .
        }
    }
}
