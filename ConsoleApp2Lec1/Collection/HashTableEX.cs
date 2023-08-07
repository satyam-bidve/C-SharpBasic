using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1.Collection
{
    internal class HashTableEX
    {
        public void HashTableEx() 
        {
            Console.Clear();
            Console.WriteLine("------------------------ HashTable ------------------");
            Console.WriteLine("\tThe Hashtable is a non-generic collection that stores key-value pairs, similar to generic Dictionary<TKey, TValue> collection.");
            Console.WriteLine("\tKeys must be unique and cannot be null.Values can be null or duplicate.");
            Console.WriteLine("------------------------ OutPut -----------------------");

            Farmers satyamFar, vijayfar, sagarfar, rohanfar, saurabhfar;
            CollectionEX.GetfarmersRecord(out satyamFar, out vijayfar, out sagarfar, out rohanfar, out saurabhfar);

            // creating Hashtable 
            Hashtable FarHash = new Hashtable();
            FarHash.Add(11, satyamFar); 
            FarHash.Add(22, vijayfar);
            FarHash.Add(33, sagarfar);
            FarHash.Add(44, rohanfar);
            FarHash.Add(55, saurabhfar);

            foreach (Farmers i in FarHash.Values)
            {
              
                Console.WriteLine($"name : {i.name}");
                Console.WriteLine($"landSize : {i.LandSize}/n");
            }

            // All other methods are same as dictionary only diffrence is in hashtable the key is in hashcode  
        }
    }
}
