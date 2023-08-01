using System;
using ClassLibraryForAccessModi;

namespace ConsoleApp2Lec1.AccessModifiers
{
    internal class AccessModiPro
    {
        public void AccessInMainEx()
        {
            Console.Clear();
            Console.WriteLine("--------------------------Access Modifires---------------------------");
            Console.WriteLine("All types and type members have an accessibility level. " +
                "The accessibility level controls whether they can be used from other code in your assembly or other assemblies.\n");
            Console.WriteLine("\t1.public: The type or member can be accessed by any other code in the same assembly or another assembly that references it. " +
                "The accessibility level of public members of a type is controlled by the accessibility level of the type itself.\n");
            Console.WriteLine("\t2.private: The type or member can be accessed only by code in the same class or struct.\n");
            Console.WriteLine("\t3.protected: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.\n");
            Console.WriteLine("\t4.internal: The type or member can be accessed by any code in the same assembly, but not from another assembly. In other words," +
                " internal types or members can be accessed from code that is part of the same compilation.\n");
            Console.WriteLine("\t5.protected internal: The type or member can be accessed by any code in the assembly in which it's declared, " +
                "or from within a derived class in another assembly.\n");
            Console.WriteLine("\t6.private protected: The type or member can be accessed by types derived from the class that are declared within its containing assembly.\n");
            Console.WriteLine("------------------------ OutPut -----------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**** there is no such visible output check the code itself****");
            Console.ResetColor();
            AccessModifiersExample acsessObj = new AccessModifiersExample();

            acsessObj.PublicMethod();   // Accessible since it's public.

            // acsessObj.PrivateMethod(); // Not accessible; private method can only be accessed within the same class.

     //       acsessObj.InternalMethod(); // Accessible since the .NET Console project and Class Library project are in the same assembly.

            // acsessObj.ProtectedMethod(); // Not accessible; protected method can only be accessed within the same class or derived classes.

     //       acsessObj.ProtectedInternalMethod();     // Accessible since it's either protected or internal.

            // acsessObj.PrivateProtectedMethod();  // Not accessible; private protected method can only be accessed within the same class or derived classes in the same assembly.
        }

    }
}
