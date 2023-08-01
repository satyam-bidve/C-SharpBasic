using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForAccessModi
{
    public  class AccessModifiersExample // if its internal then cant access the class in our main project 
    {
        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("This is an internal method.");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("This is a protected internal method.");
        }

        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("This is a private protected method.");
        }
    }
}
