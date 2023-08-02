using ConsoleApp2Lec1.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1.Collection
{
    /// <summary>
    /// ArrayList is the data collection of type object 
    /// itr has index , dynamic in size (shrink and grow ) 
    /// 
    /// </summary>
    internal class ArrayListEX
    {
        public void ArrayListEx()
        {
            Console.Clear();
            Console.WriteLine("------------------------ ArrayListEx------------------");
            Console.WriteLine("\tIn C#, the ArrayList is a non-generic collection of objects whose size increases dynamically. \n" +
                "\tIt is the same as Array except that its size increases dynamically.\n");
            Console.WriteLine("------------------------ OutPut -----------------------");

            // Creates and initializes a new ArrayList.
            ArrayList ArrayListOfCars = new ArrayList();
            ArrayListOfCars.Add("Supra");
            ArrayListOfCars.Add("GtR");
            ArrayListOfCars.Add(350);
            //--------------------------------// we can add other array in list 
            Vehicals[] vehicalArray = new Vehicals[2];   
            vehicalArray[0]= new Vehicals();
            vehicalArray[0].name = "safari";
            vehicalArray[0].company = "tata";
            vehicalArray[0].speed = "380km/h";
            vehicalArray[1] = new Vehicals();
            vehicalArray[1].name = "G-wagon";
            vehicalArray[1].company = "mercedease";
            vehicalArray[1].speed = "450km/h";
            //-----------------------------------
            ArrayListOfCars.Add(vehicalArray);
            // Displays the properties and values of the ArrayList.
            Console.WriteLine("---------ArrayListOfCars--------");

            Console.WriteLine("---- Preforming oprations on ArrayList  by its Proppertis ");
            Console.WriteLine( " .Count ->: {0}", ArrayListOfCars.Count );
              Console.WriteLine( ".Capacity ->:{0}", ArrayListOfCars.Capacity );
            Console.WriteLine(".ISFixedSize ->:{0}", ArrayListOfCars.IsFixedSize);
            Console.WriteLine(".IsReadOnly ->:{0}", ArrayListOfCars.IsReadOnly);
            Console.WriteLine(".IsSynchonized ->:{0}", ArrayListOfCars.IsSynchronized);



            Console.WriteLine("---- Preforming oprations on ArrayList  by its method");

            ArrayListOfCars.Add("datson z "); // adds new element that is object
            Console.Write("Printing array after element aadd");
            PrintValues(ArrayListOfCars);

            ArrayListOfCars.Remove(350); // removes the perticuler object from the arraylist
            ArrayListOfCars.RemoveAt(0); // removes the  object from perticuler index . .removeRange(index1, index3)
            Console.Write("Printing array after remove");
            PrintValues(ArrayListOfCars);

            ArrayListOfCars.Reverse();
            Console.Write("Printing array in reverse ");
            PrintValues(ArrayListOfCars);

           // ArrayListOfCars.Sort();  // sorts the array in alphabetical order
            Console.Write("Printing array after sorting");
            PrintValues(ArrayListOfCars);

            Console.Write( "Printing array" );
            PrintValues(ArrayListOfCars);

            // there are many more methos in documentation
         }

            public static void PrintValues(IEnumerable carList)
            {
                foreach (Object car in carList)
                    Console.Write("   {0}", car);
                Console.WriteLine();
            }

    }
}
