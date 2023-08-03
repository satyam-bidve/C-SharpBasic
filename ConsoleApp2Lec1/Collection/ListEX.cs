using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace ConsoleApp2Lec1.Collection
{
    /// <summary>
    /// List . is the collection class in system.Collection.Generic
    ///        it is a generic version of arrayList - Strict type 
    ///        access by indexing , its a fast becouse of no type casting is needed 
    ///        Complile time type checking 
    /// </summary>
    internal class ListEX
    {
        public void ListEx()
        {
            Console.Clear();
            Console.WriteLine("------------------------ ListEx------------------");
            Console.WriteLine("\tList<T> is a generic class in C# that represents a dynamic-sized collection of elements of a specified type T,\n " +
                "\tallowing for easy manipulation and access of elements.\n");
            Console.WriteLine("\t it access by indexing , its a fast becouse of no type casting is needed \r\n \tComplile time type checking ");
            Console.WriteLine("------------------------ OutPut -----------------------");




            // 1. list is strongly type so lets make a list of farmers from farmers class 
            List<Farmers> listOfFarmers = new List<Farmers>();
            listOfFarmers.Add(new Farmers() {name = "satyam" , district ="nashik" ,LandType="arable", LandSize="30ACR" });
            listOfFarmers.Add(new Farmers() { name = "Rushikesh", district = "Nagar", LandType = "hayfields", LandSize = "68ACR" });
            listOfFarmers.Add(new Farmers() { name = "Atul", district = "pune", LandType = "arable", LandSize = "73ACR" });
            listOfFarmers.Add(new Farmers() { name = "Sachin", district = "mumbai", LandType = "hayfields", LandSize = "90ACR" });

            // printing list 
            PrintValues(listOfFarmers);

            // ---------------------------- Here we perform the verious oprations on ListOfFarmes 
            // Filtering farmers with land size > 45ACR using lambda expression
            List<Farmers> farmersWithLargeLand = listOfFarmers.Where(f => Convert.ToInt32(f.LandSize.Substring(0, f.LandSize.Length - 3)) > 45).ToList(); 
            // toList to convert the result to the list 
            // f here represents the each farmer in the list lambda function lis ke arrow function 
            // where is the part of LINQ statement
            Console.WriteLine("---------Framers with Large Land -------");
            PrintValues(farmersWithLargeLand);
            Console.WriteLine("---------Farmers only name by SELECT LINQ");
            List<String> farmersNames = listOfFarmers.Select(f => f.name).ToList();
           // PrintValues(farmersNames); this will give error ecaouse we type change FArmer and String
            foreach (String f in farmersNames)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("========================== int oprations");
            //2. list of integers 
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(26);
            numbers.Add(34);
            numbers.Add(43);
            numbers.Add(3);
            numbers.Add(41);
            numbers.Add(69);
            numbers.Add(21);
            numbers.Add(8);
            Console.WriteLine("---| printing numbers");
            PrintValues1(numbers);

            List<int> numAccending = numbers.OrderBy(x => x).ToList(); // also we can use simple sort method 
           // numbers.Sort();  same type :)
            Console.WriteLine("---| printing numbers in ac order");
            PrintValues1(numAccending);

            // find and find all 
            int fistOccuranceOfMatch = numbers.Find(n => n > 20); // n is num in list andother is codition
                                                                  // in this the fist number that satisfy the condition will assine 
            Console.WriteLine($"The fisrt number that is greater than 20 in list is{fistOccuranceOfMatch}");
            // same as findAll will give the list of numbers that matches the condition 

            numbers.Remove(26); // removes the number 
            numbers.RemoveAt(4); // removes the perticuler num at given index 
            numbers.RemoveAll(n => n % 2== 0); // will remove all the numbers that are even 


            Console.WriteLine("---| printing numbers that are odd after removeAll opration");
            PrintValues1(numbers);




        }

        public static void PrintValues(IEnumerable<Farmers> listOfFarmers) // NEED to specify the type if IEnumerable
        {
            foreach (Farmers farmer in listOfFarmers)
            {
                Console.WriteLine("details of farmers are as");
                Console.WriteLine($"name = {farmer.name} district = {farmer.district} landtype = {farmer.LandType} size = {farmer.LandSize}");
                Console.WriteLine();
            }
        }

        public static void PrintValues1(IEnumerable numbers)
        {
            foreach (Object num in numbers)
                Console.WriteLine(num);
            Console.WriteLine();
        }


    }
}
