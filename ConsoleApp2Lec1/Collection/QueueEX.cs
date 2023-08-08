using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp2Lec1.Collection
{
    internal class QueueEX
    {
        public void QueueEx() 
        {
            Console.Clear();
            Console.WriteLine("------------------------ Queue ------------------");
            Console.WriteLine("\t Store data in a such form that first instert element will be the first come out FIFO - First in first Out manner\n");
            Console.WriteLine("\t  are of two types Generic and non-generic, Can Contain duplicated");
            Console.WriteLine("------------------------ OutPut -----------------------");

            // Generic Queue
            Queue<String> GenericQueue = new Queue<String>();
            GenericQueue.Enqueue("mango");
            GenericQueue.Enqueue("apple");
            GenericQueue.Enqueue("Watermelon");
            GenericQueue.Enqueue("banana");
            GenericQueue.Enqueue("stroberry");

            // printing queue
            foreach (var item in GenericQueue)
            {
                Console.WriteLine(item);
            }

            // Remove from Queue
            GenericQueue.Dequeue(); // remove mango 

           // nonGeneric 
           Queue nonGenericQueue = new Queue();
            nonGenericQueue.Enqueue(95); // can add anytype
            nonGenericQueue.Enqueue(45); 
            nonGenericQueue.Enqueue(93); 

            nonGenericQueue.Dequeue(); // remove 95
        }
    }
}
