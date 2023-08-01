using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1.Interface
{
    /// <summary>
    /// Like a class, Interface can have methods, properties, events, and indexers
    /// as its members. But interfaces will contain only the declaration of the members.
    /// The implementation of the interface’s members will be given by class who implements the interface implicitly or explicitly.
    /// </summary>
    internal interface InterfaceEX
    {
        void greet();
    }

    class testClass : InterfaceEX
    {
        public void InterfaceInfo()
        {
            Console.Clear();
            Console.WriteLine("------------------------ INTERFACE------------------");
            Console.WriteLine("An interface contains definitions for a group of related functionalities that a non-abstract class or a struct must implement.\n " +
                "An interface may define static methods, which must have an implementation.\n");
            Console.WriteLine("------------------------ OutPut -----------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**** there is no such visible output check the code itself****");
            Console.ResetColor();

        }
        #region implement interface implicitly
        /* void InterfaceEX.greet()
         {
             throw new NotImplementedException();
         }*/
        #endregion 

        // explecitly implemented 
        public void greet()
        {
            throw new NotImplementedException();
        }
    }
}
