using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Lec1.Constuctor
{
    internal class PrivateConstructorEx
    {
        /// <summary>
        /// When a constructor is created with a private specifier, it is not possible for other classes to derive from this class,
        /// neither is it possible to create an instance of this class. They are usually used in classes that contain static members only
        /// </summary>
        private PrivateConstructorEx ()
        {
            
        }
        public static int apple;
        public static int Count()
        {
            return ++apple;
        }
    }

    public class TestPrivateConstuctor //: PrivateConstructorEx  can't inherite the class 
    {
        public void TestPrivetConst()
        {
            // PrivateConstructorEx obj = new PrivateConstructorEx(); // cant create 
            PrivateConstructorEx. apple = 200;
          int result =   PrivateConstructorEx. Count();
            Console.WriteLine($"this is the updated count {result}");
        }
    }
}
