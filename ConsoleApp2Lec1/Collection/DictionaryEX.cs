using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1.Collection
{
    internal class DictionaryEX
    {
        /*Keys must be unique and cannot be null.
         Values can be null or duplicate.
         Values can be accessed by passing associated key in the indexer e.g. myDictionary[key]
         Elements are stored as KeyValuePair<TKey, TValue> objects.*/
        public void DictionaryEx() 
        {
            Console.Clear();
            Console.WriteLine("------------------------ Dictionary------------------");
            Console.WriteLine(" \t The Dictionary<TKey, TValue> is a generic collection that stores key-value pairs in no particular order.");
            Console.WriteLine("\t Keys must be unique and cannot be null.");
            Console.WriteLine(" \t Values can be null or duplicate.\r\n         Values can be accessed by passing associated key in the indexer e.g. myDictionary[key]\r\n         Elements are stored as KeyValuePair<TKey, TValue> objects.*/");
            Console.WriteLine("------------------------ OutPut -----------------------");

            // Create Dictionary of type farmer
            Dictionary< int ,Farmers> FarmersDict = new Dictionary<int, Farmers>();

            Farmers satyamFar , vijayfar ,sagarfar , rohanfar , saurabhfar;
            CollectionEX.GetfarmersRecord(out satyamFar ,out vijayfar,out sagarfar , out rohanfar ,out saurabhfar);

            FarmersDict.Add(11, satyamFar); // adding values in dictionary key , value
            FarmersDict.Add(22, vijayfar);
            FarmersDict.Add(33, sagarfar);
            FarmersDict.Add(44, rohanfar);
            FarmersDict.Add(55, saurabhfar);

            Console.WriteLine($"values for farmer1 name is  {FarmersDict[11].name}\n\n"); // accessing the object [values in dict] by key
           
            foreach (var f in FarmersDict.Values)  
            {
                // Console.WriteLine(f.ToString()); prints key and object type ❌
                Console.WriteLine($"    name : {f.name}");
                Console.WriteLine($"District : {f.district}");
                Console.WriteLine($"Landsize : {f.LandSize}");
                Console.WriteLine($"landType : {f.LandType} \n");
            }

            // filter dictionary on consition of farmers having land size > 50 ARC
            Console.WriteLine("List of farmers with large land\n");
            var bigFarmers = FarmersDict.Where(f => Convert.ToInt32(f.Value.LandSize.Substring(0,f.Value.LandSize.Length - 3)) > 50);
           
            foreach (var f in bigFarmers) 
            {
                // Console.WriteLine(f.ToString()); prints key and object type ❌
                Console.WriteLine($"    name : {f.Value.name}");
                Console.WriteLine($"District : {f.Value.district}");
                Console.WriteLine($"Landsize : {f.Value.LandSize}");
                Console.WriteLine($"landType : {f.Value.LandType} \n");
            }

        }
    }
}
