using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp2Lec1.Collection
{
    internal class SortedListEX
    {
        public  void SortedListEx() 
        {
            // SortedList can be generic and non generic type it is sorted by the key and can be access by the index 
            Console.Clear();
            Console.WriteLine("------------------------ SortedList ------------------");
            Console.WriteLine("\t SortedList can be generic and non generic type it is sorted by the key and can be access by the index\n");
            Console.WriteLine("------------------------ OutPut -----------------------");

            // This one is generic sorted list with key type int and values are of type string
            SortedList <int , String> GerericSortedList = new SortedList <int , String>();
            GerericSortedList.Add(3,"hello");
            GerericSortedList.Add(7, "Hii");
            GerericSortedList.Add(9, "Good");
            GerericSortedList.Add(2, "morning");

            // printing the sorted list
            foreach(Object i in GerericSortedList.Values)
            {
                Console.WriteLine($"Values in Sorted list - {i}");
            }

            // This will print as 
            /*------------------------ OutPut -----------------------
                Values in Sorted list - morning  2
                Values in Sorted list - hello    3
                Values in Sorted list - Hii      7
                Values in Sorted list - Good     9                    */ // This is the printing order of sorting list 

            Console.WriteLine("Other Methods ");
            GerericSortedList.Remove(7); // This will remove the Object on which key is pass 
            GerericSortedList.RemoveAt(2); // This will remove by the provided index 
                                           //   GerericSortedList.Clear(); // to remove all the objets from list 

            // Now non-Generic Sorted List  ❌ Key must be same type in all over the list 

            SortedList NonGenericSortedList = new SortedList();
            NonGenericSortedList.Add(44, 89);
            NonGenericSortedList.Add(55, "Dhule");
            NonGenericSortedList.Add(36,new Farmers() {name="satyam" ,district="Nashik", LandSize="987ACR",LandType="Agri"}); // cant Store any key with diff datatype 
            NonGenericSortedList.Add(39, "Pune");
            NonGenericSortedList.Add(49, new Vehicals() { company="Toyota", name="Hilux", speed="Unlimited"});
            NonGenericSortedList.Add(98, "Mumbai");

            // As this is non Generic type We can Store Any type of data in it 
            int j = 1;
            foreach (Object i in NonGenericSortedList.Values)
            {
                
                Console.WriteLine($"value at index {j++} as - {i}");
            }

            SortedList SecNonGenericSortedList = new SortedList();
            SecNonGenericSortedList.Add("key1", "Satyam");
            SecNonGenericSortedList.Add("key2", "Manohar");
            SecNonGenericSortedList.Add("key3", " Bidve");

            foreach (var item in SecNonGenericSortedList.Keys)
            {
                Console.WriteLine($"Key - {item}");
            }



        }
    }
}
