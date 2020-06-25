using System;
using System.Linq;
using System.Text;

namespace DEC_CourseAssignments
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Assignment01_SumArray();                		//2.5.1
            //Assignment02_CheckAscendingOrder();      		//2.5.2
            //Assignment03_CheckWordExist();           		//2.5.3
            //Assignment04_AppendStrings();            		//2.5.4
            //Assignment05_CountVowelsConsonants();     	//2.5.5
            // Assignment06_CheckTimeFormat();            	//2.5.6
            Console.ReadKey();
        }

        #region 2.5.1

        public static void Assignment01_SumArray()
        {
            Console.WriteLine("Enter Numbers separated by comma");
            var userInput = Console.ReadLine();
            var userInputSplit = userInput.Split(',');
            double sum = 0;
            foreach (var number in userInputSplit) sum = sum + double.Parse(number);

            Console.WriteLine($"The input sum :→ {sum}");
        }

        #endregion 2.5.1

        #region 2.5.2

        public static void Assignment02_CheckAscendingOrder()
        {
            Console.WriteLine("Enter Numbers separated by comma");
            var userInput = Console.ReadLine();
            var userInputSplit = userInput.Split(',');
            var ascendingOrder = true; // Assuming the numbers are in ascending order till we found first oddity
            for (var i = 1; i < userInputSplit.Length; i++)
            {
                if (i == 0) continue;
                if (double.Parse(userInputSplit[i]) > double.Parse(userInputSplit[i - 1]))
                    //if every number greater than the last number then the rule remain true
                {
                    ascendingOrder = true;
                }
                else
                {
                    ascendingOrder = false;
                    break;
                }
            }

            Console.WriteLine(ascendingOrder
                ? "the numbers are in ascending order"
                : "the numbers are NOT in ascending order");
        }

        #endregion 2.5.2

        #region 2.5.3

        public static void Assignment03_CheckWordExist()
        {
            Console.WriteLine("Enter text:");
            var userInput = Console.ReadLine();
            Console.WriteLine(userInput.ToLower().Contains("hello")
                ? "The string Contains Hello"
                : "The string DOES NOT Contain Hello");
        }

        #endregion 2.5.3

        #region 2.5.4

        public static void Assignment04_AppendStrings()
        {
            var userInput = new StringBuilder();
            Console.WriteLine("Enter 1ˢᵗ string:");
            userInput.Append(Console.ReadLine());
            Console.WriteLine("Enter 2ⁿᵈ string:");
            userInput.Append(Console.ReadLine());
            Console.WriteLine("Enter 3ʳᵈ string:");
            userInput.Append(Console.ReadLine());
            Console.WriteLine(userInput);
        }

        #endregion 2.5.4

        #region 2.5.5

        public static void Assignment05_CountVowelsConsonants()
        {
            Console.WriteLine("Enter text:");
            var userInput = Console.ReadLine();
            string[] vowels = {"a", "e", "i", "o", "u"};
            int vowelsCount = 0, constantsCount = 0;
            foreach (var chr in userInput)
            {
                if (!char.IsLetter(chr)) continue;
                var value = vowels.Contains(chr.ToString()) ? vowelsCount++ : constantsCount++;
            }

            Console.WriteLine(
                $"Total Number of Vowels is {vowelsCount} , total number of constant is {constantsCount}");
        }

        #endregion 2.5.5

        #region 2.5.6

        public static void Assignment06_CheckTimeFormat()
        {
            Console.WriteLine("Enter time in **:** format");
            var userInput = Console.ReadLine();
            if (!userInput.Contains(":") || userInput == "")
            {
                Console.WriteLine("Invalid Format");
            }
            else
            {
                var dateFromInput = userInput.Split(':');
                var hour = dateFromInput[0];
                var minute = dateFromInput[1];
                if (int.Parse(hour) < 23 && int.Parse(minute) < 59)
                    Console.WriteLine("The time is valid and in correct format");
                else
                    Console.WriteLine("Invalid Format");
            }
        }

        #endregion 2.5.6
    }
}