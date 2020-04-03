using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CourseAssignments
{
    class Arrays
    {
        // Call the method you want to execute.
        // GetArrayInputs();                          //Task 01
        //SumArrayValues();                           //Task 02
        //GetMaximumAndMinimumValues();               //Task 03
        //GetEvenAndOdd();                            //Task 04
        //Get3by3ArrayDiagonalSum();                  //Task 05
        //GetMinimumValueAndItsIndex();               //Task 06
        //GetAdditionOfTwoArrays();                   //Task 07
        //GetValuesAndDeleteOne();                    //Task 08
        //GetDuplicateValues();                       //Task 09
        //GetUniqueValues();                          //Task 10
        // Task 01
        public static void GetArrayInputs()
        {
            Console.WriteLine("Enter the Array Length");
            int.TryParse(Console.ReadLine(), out int arrayLength);
            int[] arrayInputs = new int[arrayLength];
            Console.WriteLine("———————————————————————");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Enter the value {0} in the array", i + 1);
                //arrayInputs[i] = (int)int.Parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out arrayInputs[i]);
            }
            Console.WriteLine("———————————————————————");
            int[] arrayInputsRevesed = arrayInputs;
            Array.Reverse(arrayInputsRevesed);      // Reversing the Array Order
            for (int k = 0; k < arrayInputsRevesed.Length; k++)
            {
                Console.WriteLine(arrayInputsRevesed[k]);
            }
            Console.Read();
        }
        // Task 02		
        public static void SumArrayValues()
        {
            Console.WriteLine("Enter 3 Values to be summed");
            int[] array = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the value {0} in the array", i + 1);
                int.TryParse(Console.ReadLine(), out array[i]);
            }
            Console.WriteLine("The Sum of array values {0}", array.Sum()); // Using the built-in function Sum in .net array class
            Console.Read();
        }
        // Task 03
        public static void GetDuplicateValues()
        {
            Console.WriteLine("Enter The Array Size");
            int.TryParse(Console.ReadLine(), out int x);
            int[] array = new int[x];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the value {0} in the array", i + 1);
                int.TryParse(Console.ReadLine(), out array[i]);
            }
            var arrayGroup = array.GroupBy(key => key);
            int duplicatesCounter = 0;
            foreach (var key in arrayGroup)
                if (key.Count() > 1)
                {
                    Console.WriteLine("Number {0} duplicated {1} times", key.Key, key.Count());
                    duplicatesCounter++;
                }
            Console.WriteLine("Total duplicates values in the entered values {0}", duplicatesCounter);
            Console.Read();
        }
        // Task 03
        public static void GetUniqueValues()
        {
            Console.WriteLine("Enter The Array Size");
            int.TryParse(Console.ReadLine(), out int x);
            int[] array = new int[x];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the value {0} in the array", i + 1);
                int.TryParse(Console.ReadLine(), out array[i]);
            }
            var arrayGroup = array.GroupBy(key => key);
            foreach (var key in arrayGroup)
                if (key.Count() == 1)
                    Console.WriteLine("Number {0} is unique in the array", key.Key);
            Console.Read();
        }
        // Task 05	
        public static void GetMaximumAndMinimumValues()
        {
            Console.WriteLine("Enter 5 Values to be get the minimum and maximum value");
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the value {0} in the array", i + 1);
                int.TryParse(Console.ReadLine(), out array[i]);
            }
            Console.WriteLine("The Maximum value you entered equals =  {0}", array.Max());
            Console.WriteLine("The Minimum value you entered equals =  {0}", array.Min());
            Console.Read();
        }
        // Task 06	
        public static void GetEvenAndOdd()
        {
            int even = 0, odd = 0;
            int[] array = new int[6];
            Console.WriteLine("Enter 6 Values to be get the even and odd numbers count");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the value {0} in the array", i + 1);
                int.TryParse(Console.ReadLine(), out array[i]);
                if (array[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine("The count of even numbers entered =  {0}", even);
            Console.WriteLine("The count of odd numbers entered =  {0}", odd);
            Console.Read();
        }
        // Task 07
        public static void GetValuesAndDeleteOne()
        {
            Console.WriteLine("Enter The Array Size");
            int.TryParse(Console.ReadLine(), out int x);
            int[] array = new int[x];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the value {0} in the array", i + 1);
                int.TryParse(Console.ReadLine(), out array[i]);
            }
            int counterInForEach = 0;
            foreach (int index in array)
            {
                Console.WriteLine("The value you at index {0} =  {1}", counterInForEach, index);
                counterInForEach++;
            }
            Console.WriteLine("Enter The index value you want to delete");
            int.TryParse(Console.ReadLine(), out int y);
            if (y <= array.Length)
                array[y] = 0;
            else
                Console.WriteLine("Wrong value");
            counterInForEach = 0;
            foreach (int index in array)
            {
                Console.WriteLine("The value in the updated array you at index {0} =  {1}", counterInForEach, index);
                counterInForEach++;
            }
            Console.Read();
        }
        // Task 08
        public static void GetAdditionOfTwoArrays()
        {
            Console.WriteLine("Enter First Array Size");
            int.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine("Enter Secined Array Size");
            int.TryParse(Console.ReadLine(), out int y);
            int[] firstArray = new int[x];
            int[] secondArray = new int[y];
            Console.WriteLine("———————————————————————");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine("Enter the value {0} in the array", i + 1);
                int.TryParse(Console.ReadLine(), out firstArray[i]);
            }
            Console.WriteLine("———————————————————————");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.WriteLine("Enter the value {0} in the array", i + 1);
                int.TryParse(Console.ReadLine(), out secondArray[i]);
            }
            int sumArraySize = firstArray.Length > secondArray.Length ? firstArray.Length : secondArray.Length;
            int smallestArrayLength = firstArray.Length < secondArray.Length ? firstArray.Length : secondArray.Length;
            int[] sumArray = new int[sumArraySize];
            for (int i = 0; i < smallestArrayLength; i++)
            {
                sumArray[i] = firstArray[i] + secondArray[i];

            }
            for (int i = smallestArrayLength; i < sumArray.Length; i++)
            {
                if (x > y)
                    sumArray[i] = firstArray[i];
                else
                    sumArray[i] = secondArray[i];
            }
            int counterInForEach = 0;
            foreach (int keee in sumArray)
            {
                Console.WriteLine("Summation of Values at index {0} = {1}", counterInForEach, keee);
                counterInForEach++;
            }

            Console.Read();
        }
        // Task 09
        public static void GetMinimumValueAndItsIndex()
        {
            int[,] array = new int[3, 3];
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int minmumValue = int.MaxValue;
            String minmumValueLocation = "";
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.WriteLine("Please the value if cell in Column {0} and Row {1}", i, j);
                    int.TryParse(Console.ReadLine(), out array[i, j]);
                    if (array[i, j] < minmumValue)
                    {
                        minmumValue = array[i, j];
                        minmumValueLocation = "[" + i + ", " + j + "]";
                    }
                }
            }
            Console.WriteLine("The lowest  value in the entered number ={0} \n" +
                              "The Index of this value in the array  =  {1}", minmumValue, minmumValueLocation);
            Console.Read();
        }
        // Task 10
        public static void Get3by3ArrayDiagonalSum()
        {
            int sum = 0;
            int[,] array = new int[,]
            {
                {1, 2, 3}
                ,{1, 2, 3}
                ,{1, 2, 3}
            };
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                        sum += array[i, j]; // Diagonal cells row number matches the column number
                }
            }
            Console.WriteLine("Diagonal summation =  {0}", sum);
            Console.Read();
        }
    }
}
