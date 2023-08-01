using System;
using System.Collections.Generic;


namespace ConsoleApp2Lec1
{
    internal class ArrayStucture
    {
        // As in program.cs here also we give options to try
        // array topics its like having a topics from chapter
        public  static void ArrayTopics()
        {
            Console.Clear();
            Console.WriteLine("------- chapter Array--------");
            Console.WriteLine(" >>> 1 - single array ");
            Console.WriteLine(" >>> 2 - Object of   array ");
            Console.WriteLine(" >>> 3 - 2 diamentional array  ");
            Console.WriteLine(" >>> 4 - Jagged Array  ");
            Console.WriteLine(" >>> 5 - Binary Search in Array ");
            Console.WriteLine(" >>> 6 - Clear Array Elements  ");
            Console.WriteLine(" >>> 7 - Reverse Array  ");

            Console.WriteLine(" >>> 8 - Copy Array  ");
           
            Console.WriteLine(" >>> 10 - Sort The Array  ");
            Console.WriteLine(" >>> 11 - Leanear Search In Array ");
        }

        // 👇 - here we take users choice and show them specific topic ✌️
        public  static void TakeInOpration()
        {
            Console.WriteLine("Enter which topic you want to - visit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    OneDArray();
                    break; 
                case 2:
                    ArrayOfObjects();
                    break;
                case 3:
                    TwoDiamentionalArray();
                    break;
                case 4:
                    JaggedArrayEx();
                    break;
                case 5:
                    BinarySearchExample();
                    break;
                case 6:
                    ClearArrayElements();
                    break;
                case 7:
                    ReverseArray();
                    break;
                case 8:
                    CopyArrayElements();
                    break;
                case 9:
                    SortArray();
                    break;
                case 10:
                    ArrayLinearSearch();
                    break;








            }
        }

        // methods for each topic -------------------👇

        //1. method for single array
        static void OneDArray()
        {
            Console.Clear();
            Console.WriteLine("                          ---------------Array-------------");

            Console.WriteLine(" \t \t What is array in simple words? An array is \n" +
                " \t \t an arrangement of numbers, pictures or objects formatted into rows and columns according to \n" +
                "\t \t  their type. In coding and programming, an array is a collection of items, or data, stored in\n" +
                "\t \t  contiguous memory locations, also known as database systems ");

            // creating array 
            int[] evenNums = { 2, 4, 6, 8, 10 };
            // printing array values 
            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]);

        }

        // Use Array of object .. store objects in array - itrate on it 

        static void ArrayOfObjects()
        {
            Console.Clear();
            Console.WriteLine("                          ---------------Array-------------");

            Console.WriteLine(" \t \t We know that an array is a collection of the same data type that \n" +
                " \t \t dynamically creates objects and can have elements of primitive types. Java allows us to store objects in an array.\n " +
                "\t \t In Java, the class is also a user-defined data type. An array that conations class type elements are known as an array of objects.\n");

            // text to show user and take size of array 
            Console.WriteLine(" - - ");
            Console.WriteLine("Store new cars in your car collection ");
            Console.WriteLine(" - - ");
            Console.WriteLine("Enter how many cars do you want to store ");
            int carsCount = Convert.ToInt32(Console.ReadLine()); // here we store the size of array 
            Vehicals [] carCollection = new Vehicals[carsCount];  // creatin an aaray with given size 

            // now we need to store and object -> car with its details to an array .. so need to loop 

            // Enter details of your car to store it in collection
            for(int i = 0;i < carsCount; i++)
            {
                carCollection[i] = new Vehicals(); // create new object (car ) for i index
                Console.WriteLine("Enter details for car number - {0}",i+1);

                Console.Write(" Enter car name : ");
                carCollection[i].name= Console.ReadLine();

                Console.Write(" Enter car brand : ");
                carCollection[i].company = Console.ReadLine();

                Console.Write(" Enter car speed : ");
                carCollection[i].speed = Console.ReadLine();
            }

            // printing array of object 
            Console.WriteLine("---------------------------------");
            Console.WriteLine("  Here is your car collection ");
            foreach(Vehicals car in carCollection) // need to give data tpe as object in this case Vehicals is our object type
            {
                Console.WriteLine(" {0}  {1}  {2}",car.name,car.company,car.speed);
            }

        }



        // Lets try 2 Diamentioanal array ... its like a grid having rows and coloums 
        public static  void TwoDiamentionalArray()
        {
            Console.Clear();
            Console.WriteLine("                          ---------------Array-------------");

            Console.WriteLine(" \t  \t A two-dimensional array, also \n" +
                " \t  \t known as a 2D array, is a collection of data elements arranged in  \n" +
                " \t  \t a grid-like structure with rows and columns. Each element in the array is referred to as a cell and can be accessed \n" +
                " \t  \t by its row and column indices/indexes \n ");

            Console.WriteLine("Enter the size of array like 2x3 : ");
            String userInput = Console.ReadLine(); // Taking the size of 2d array its in String

            int row = int.Parse(userInput.Split('x')[0]); 
            int coloumn = int.Parse(userInput.Split('x')[1]);
            //  👆  here we Split UserInput by delimiter of x so we get ["2" ,"3"] in array form so at 0 index take out element and convert to int assigne to row veriable 

            int[,] TwoDArray = new int[row, coloumn]; // Syntax of creating 2D array 

            //Now to store elements in array we need the nested for loop to travel on each postion of elements 

            for( int i = 0;i < row;i++)
            {
                for( int j = 0;j < coloumn; j++)
                {
                    Console.Write("Enter the element of array on postion of {0}-{1}  - ",i,j);
                    TwoDArray[i,j]=Convert.ToInt32(Console.ReadLine());

                }
            }


            // Same to Print Elements of array 
            Console.WriteLine("");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloumn; j++)
                {

                    Console.Write("  {0}",TwoDArray[i,j]);

                }
                Console.WriteLine();
            }
        }





        // Jagged Array 
        // its and Array of Array 
        /*
         1   d , f, u ,h 
         2   w, x,f , i , w 
         */
        public static void JaggedArrayEx()
        {
            Console.Clear();

            Console.WriteLine(" \t \t A jagged array is an array whose elements are \n " +
                " \t \t  arrays, possibly of different sizes. A jagged array is sometimes \n " +
                " \t \t  arrays, possibly of different sizes. A jagged array is sometimes \n " +
                "\t \t  called an \"array of arrays.\" The following examples show how to declare,  \n " +
                " \t \t initialize, and access jagged arrays");


            Console.WriteLine("Enter the number of array you want to store ");
            int NoOfArray = int.Parse(Console.ReadLine());

            int[][] JaggedArray = new int[NoOfArray][];  // its a sysntax of jagged array 

            // Now we need to store child array at each index of its parent array 
            for(int i = 0; i < NoOfArray; i++)
            {
                Console.WriteLine("Enter size of {0} child array", i + 1); // taking size of each child array for everay parent element 
                int childArraySize = int.Parse(Console.ReadLine()); 
                int[] ChildArray = new int [childArraySize]; // simple Array syntax  ❌❌❌⭕ Got Error here bad Array delecarator
                Console.WriteLine("Enter Array Elements for child Array");

                for(int j = 0; j < ChildArray.Length; j++)
                {
                    ChildArray[j] = int.Parse(Console.ReadLine());
                }
                JaggedArray[i] = ChildArray;
            }

            Console.WriteLine("----  printing Our Jagged Array---");
            for( int i = 0;i < JaggedArray.Length; i++)
            {
                Console.Write("Jagged Array [{0}] = ", i);
                Console.WriteLine('{');
                for(int j = 0;j < JaggedArray[i].Length; j++)
                {
                    Console.Write("{0}-",JaggedArray[i][j]);   
                }
                Console.Write("}");
                Console.WriteLine();
            }

        }


        //--------------------------------------------------------- Array Build in Methods ----------------------------------------------------------------------------------------------------------

        #region Array General Methods
        public static int GetArraySizeFromUser()
        {
            Console.Write("Enter size of an Array : ");
            int size = int.Parse(Console.ReadLine());
            return size;
        }
        public static int[] GetIntegerArray(int ArraySize)
        {
            int[] Numbers = new int[ArraySize];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }
            return Numbers;
        }
        public static void PrintArray(int[] NumberCollection)
        {
            Console.Write("{");
            foreach (int number in NumberCollection)
            {
                Console.Write("{0}\t", number);
            }
            Console.Write("}");
            Console.WriteLine();
        }
        #endregion

        public static void BinarySearchExample()
        {
            int size = GetArraySizeFromUser();
            int[] NumberCollection = GetIntegerArray(size);

            Console.Write("Enter Element to Search : ");
            int searchElement = int.Parse(Console.ReadLine());

            int result = Array.BinarySearch(NumberCollection, searchElement);
            result = Array.IndexOf(NumberCollection, searchElement);
            if (result >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Element Found at location : {0}", result);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Element Not Found");
                Console.ResetColor();
            }
        }

        public static void ClearArrayElements()
        {
            int size = GetArraySizeFromUser();
            int[] NumberCollection = GetIntegerArray(size);

            Console.Write("Enter Number of Elements to Clear : ");
            int NumberOfElementsToClear = int.Parse(Console.ReadLine());

            Console.Write("Enter StartIndex from where to Clear the Elements ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("Printing Array Before Clear");
            PrintArray(NumberCollection);

            if ((NumberOfElementsToClear + startIndex) > NumberCollection.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invalid Input");
                Console.ResetColor();
            }
            else
            {
                Array.Clear(NumberCollection, startIndex, NumberOfElementsToClear);
                Console.WriteLine("Printing Array After Clear");
                PrintArray(NumberCollection);
            }
        }

        public static void CopyArrayElements()
        {
            int Array1Size = GetArraySizeFromUser();
            int[] SourceArray = GetIntegerArray(Array1Size);

            int Array2Size = GetArraySizeFromUser();
            int[] DestinationArray = GetIntegerArray(Array2Size);

            Console.Write("Enter Number of Elements to Copy : ");
            int NumberOfElementsToCopy = int.Parse(Console.ReadLine());

            Console.Write("Enter Start Index of Source Array to Copy the Elements : ");
            int SourceArrayStartIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter Start Index of Destination Array to Paste the Copied Elements :");
            int DestinationArrayStartIndex = int.Parse(Console.ReadLine());

            if ((NumberOfElementsToCopy + SourceArrayStartIndex) > SourceArray.Length ||
                (NumberOfElementsToCopy + DestinationArrayStartIndex) > DestinationArray.Length)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine("Array Before Copy");
                PrintArray(DestinationArray);
                Console.WriteLine();
                Array.Copy(SourceArray, SourceArrayStartIndex, DestinationArray, DestinationArrayStartIndex, NumberOfElementsToCopy);
                Console.WriteLine("Array After Copy");
                PrintArray(DestinationArray);
                Console.WriteLine();
            }


        }


        public static void ArrayLinearSearch()
        {
            int size = GetArraySizeFromUser();
            int[] Numbers = GetIntegerArray(size);

            Console.Write("Enter Element to search : ");
            int searchElement = int.Parse(Console.ReadLine());

            int result = Array.IndexOf(Numbers, searchElement);

            int LastIndexResult = Array.LastIndexOf(Numbers, searchElement);

            if (result >= 0)
            {
                Console.WriteLine("First Occurance of the Element found at location : {0}", result);
            }
            else
            {
                Console.WriteLine("Element Not Found");
            }




            if (LastIndexResult >= 0)
            {
                Console.WriteLine("Last Occurance of the Element found at location : {0}", LastIndexResult);
            }
            else
            {
                Console.WriteLine("Element Not Found");
            }





        }

        public static void ReverseArray()
        {
            int size = GetArraySizeFromUser();
            int[] Numbers = GetIntegerArray(size);

            Console.WriteLine("Printing Array Before Reverse");
            Console.WriteLine();
            PrintArray(Numbers);

            Array.Reverse(Numbers);
            Console.WriteLine("Printing Array After Reverse");
            Console.WriteLine();
            PrintArray(Numbers);
        }

        public static void SortArray()
        {
            int size = GetArraySizeFromUser();
            int[] Numbers = GetIntegerArray(size);

            Console.WriteLine("Printing Array Before Sort");
            Console.WriteLine();
            PrintArray(Numbers);
            Console.WriteLine();

            Array.Sort(Numbers);
            Console.WriteLine("Array in Ascending Order");
            Console.WriteLine();
            PrintArray(Numbers);
            Console.WriteLine();

            Console.WriteLine("Array in Descending Order");
            Array.Reverse(Numbers);
            Console.WriteLine();
            PrintArray(Numbers);

        }




        //=====================================================================================================================================================================









        public  void ArrayStucExamples()   // This is core method of this class which is get call from PROGRAM.CS  [IMP]
        {
            Boolean playAgian = true;
           
            do
            {


                ArrayTopics();
                TakeInOpration();

                Console.WriteLine("Do you want to try another topics yes -> y and no -> n  ");
                string playAgianChoice = Console.ReadLine();
                if (playAgianChoice == "Y" || playAgianChoice == "y")
                {
                    Console.Clear();
                    playAgian = true;
                }
                else if (playAgianChoice == "N" || playAgianChoice == "n")
                {
                    playAgian = false;
                    Console.Clear();
                    Console.WriteLine("Back to main menu");

                }
            }
            while (playAgian);
        }
    }
}
