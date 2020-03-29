using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace CourseAssignment1
{
    public class Loops
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //  Console.WriteLine(var_1 * 2);
            Console.WriteLine("Choose The Operation you want to do");
            Console.WriteLine("1. Print from 1 to 100");
            Console.WriteLine("2. Print from 1 to 100");
            Console.WriteLine("3. Sum even numbers");
            Console.WriteLine("4. Sum Even Numbers from  0 to 10");
            Console.WriteLine("5. Sum Numbers Divisble By 3");
            Console.WriteLine("6. Get Number cube");
            Console.WriteLine("7. Get Odd and Even numbers COunt from 1 to 100");
            Console.WriteLine("8. Check if angles form a Triangle");
            Console.WriteLine("————————————————————————————");
            int user_choice002;
            var user_choice00 = int.TryParse(Console.ReadLine(), out user_choice002);

            if (user_choice00)
            {
                // var user_choice02 = int.Parse(Console.ReadLine());

                switch (user_choice002)
                {
                    case 1:
                        // 01   First Task
                        printTo100_for();
                        break;

                    case 2:
                        // 02   Second Task
                        printTo100_while();
                        break;

                    case 3:
                        // 03   Third Task
                        sumEvenNumbers();
                        break;

                    case 4:
                        // 04   Fourth Task
                        sumEvenNumbers_0to10();
                        break;

                    case 5:
                        // 05   Fifth Task
                        sumNumbersDiv_3();
                        break;

                    case 6:
                        // 06   Sixth Task
                        getCube();
                        break;

                    case 7:
                        // 07   Seventh Task
                        getOddEven();
                        break;
                    case 8:
                        // 07   Seventh Task
                        checkTriangAbility();
                        break;



                    default:
                        Console.WriteLine("Wrong Choice :( 😠");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong Choice :( 😠");
                Console.Beep();
            }
            Console.ReadLine();

            static double cRL_P(string msg)
            {
                Console.WriteLine(msg);
                return double.Parse(Console.ReadLine());
            }

            //



            static void printTo100_for()
            {
                Console.WriteLine("\n --------- \n");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);

                }


            }
            static void printTo100_while()
            {
                Console.WriteLine("\n --------- \n");
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine(i);
                    i++;
                }


            }


            static void sumEvenNumbers()
            {

                double sum = 0;
                var x = cRL_P("Enter even number");
                while (x % 2 == 0)
                {
                    sum += x;
                    x = cRL_P("Enter another even number");

                }
                Console.WriteLine("The Sum Of previous entered Even Numbers = {0} ", sum);


            }
            static void sumEvenNumbers_0to10()
            {

                var sum = 0;
                var x = 0;

                while (x != 10)
                {


                    if (x % 2 == 0)
                    {
                        sum += x;
                    }
                    x++;
                }
                Console.WriteLine("The Sum Of even numbers from 0 to 10= {0} ", sum);


            }

            static void sumNumbersDiv_3()
            {

                var sum = 0;
                var x = 0;

                while (x != 100)
                {


                    if (x % 3 == 0)
                    {
                        sum += x;
                    }
                    x++;
                }
                Console.WriteLine("The Sum Of even numbers from 0 to 10= {0} ", sum);


            }

            static void getCube()
            {

                var x = cRL_P("Enter The Number");
                Console.WriteLine("The cube of {0} is {1}", x, Math.Pow(x, 3));
            }
            static void getOddEven()
            {
                double even = 0;
                double odd = 0;


                for (int i = 0; i < 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        even++;

                    }
                    else { odd++; }

                }
                Console.WriteLine("From 1 to 100 there is {0} Even Number", even);
                Console.WriteLine("From 1 to 100 there is {0} Odd Number", odd);
            }







            static void checkTriangAbility()
            {

                int i = 0;
                double sum;

                do
                {
                    double x = cRL_P("Enter The First Angle");
                    double y = cRL_P("Enter The Second Angle");
                    double z = cRL_P("Enter The Third Angle");
                    sum = x + y + z;
                    bool condition = (x + y + z) == 180;
                    if (!condition)
                    {
                        i++;
                        Console.WriteLine("Try Again you have {0} chance/s remaing ", 4 - i);
                    }
                    else
                        Console.WriteLine("The Angles can form Triangle");

                } while (i < 3 && sum != 180);

            }
        }
    }
}
