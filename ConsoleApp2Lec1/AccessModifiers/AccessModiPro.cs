using System;
using ClassLibraryForAccessModi;

namespace ConsoleApp2Lec1.AccessModifiers
{
    internal class AccessModiPro
    {
        public void AccessInMainEx()
        {
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
