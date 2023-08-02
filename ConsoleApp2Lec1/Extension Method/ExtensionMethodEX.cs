using System;


namespace ConsoleApp2Lec1.Extension_Method
{
    
    internal static class ExtensionMethodEX
    {
        /// <summary>
        ///  Extention method is use in these cases 
        ///  1. when a cirtain class is in other project completly and when we get refrance of that class 
        ///     it show metadata , that we cant modify so to add such modification indirectly to that class we use 
        ///      extention method .Without modifing the original class and code .
        ///  2. when we declare class as sealed we cant inherit it and cant make changes  to it  then we can add extention method 
        ///     to modify in that class.
        /// </summary>
        public static void ExtendedMethodEx()
        {

        }

        public static void SealedExtentionMethodEX(this SealeadClass sealeadClassObj) 
        {
            Console.WriteLine("Now we can add extra fuctionality in sealed class withut inheriting it \n" +
                "this is SealedExtentionMethodEX");

        }

    }

    sealed class SealeadClass
    {
        public void SealeadClassMethod()
        {
            Console.WriteLine("I an SealeadClassMethod");
        }
    }

    public class UseOfExtensionMethods
    {
        public void useOfExtention()
        {
            Console.Clear();
            Console.WriteLine("------------------------ Extension Method------------------");
            Console.WriteLine("\t\tExtension methods enable you to \"add\" methods to existing\n types without creating a new derived type," +
                " recompiling, or otherwise modifying the original type. " +
                "\nExtension methods are static methods, but they're called as if they were instance methods on the extended type.\n");
            Console.WriteLine("------------------------ OutPut -----------------------");
            // call the extension method by sealed class object event though it is static
            SealeadClass sealeadObj = new SealeadClass();
            sealeadObj.SealeadClassMethod();
            sealeadObj.SealedExtentionMethodEX();
        }
    }
}
