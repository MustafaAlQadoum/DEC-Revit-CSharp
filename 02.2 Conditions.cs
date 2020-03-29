using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace CourseAssignment1
{
    public class Conditions
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //  Console.WriteLine(var_1 * 2);
            Console.WriteLine("Choose The Operation you want to do");
            Console.WriteLine("1. Check Number Sign [Postive -or- Negative]");
            Console.WriteLine("2. Check Numbers Equality");
            Console.WriteLine("3. Check the Greater Number");
            Console.WriteLine("4. Check Odd or Even Number");
            Console.WriteLine("5. Check if value  equal 10");
            Console.WriteLine("6. Check if angles form a Triangle");
            Console.WriteLine("7. Check Student Grade");
            Console.WriteLine("8. Expand grade letters");
            Console.WriteLine("9. Get month name & days");
            Console.WriteLine("10. Get Equation Roots");
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
                        checkPostive();
                        break;

                    case 2:
                        // 02   Second Task
                        checkEquality();
                        break;

                    case 3:
                        // 03   Third Task
                        checkGreaterNumber();
                        break;

                    case 4:
                        // 04   Fourth Task
                        checkOddity();
                        break;

                    case 5:
                        // 05   Fifth Task
                        checkValue_10();
                        break;

                    case 6:
                        // 06   Sixth Task
                        checkTriangAbility();
                        break;

                    case 7:
                        // 07   Seventh Task
                        checkGrade();
                        break;

                    case 8:
                        // 08   Eighth Task
                        gradeExpand();
                        break;
                    case 9:
                        // 09   Ninth Task
                        getMonthDays();
                        break;
                    case 10:
                        // 10   Tenth Task
                        getEquationRoots();
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

            static void cWL_P(double msg)
            {
                Console.WriteLine("Result: " + msg);
            }
            static double cRL_P(string msg)
            {
                Console.WriteLine(msg);
                return double.Parse(Console.ReadLine());
            }
            static void checkPostive()
            {

                var x = cRL_P("Enter The Number");
                bool positive = x > 0;
                if (positive)
                {
                    Console.WriteLine("You entered Postive Number");
                }
                else
                {
                    Console.WriteLine("You entered Negative Number");

                }
            }
            static void checkEquality()
            {

                var x = cRL_P("Enter The First Number");
                var y = cRL_P("Enter The Second Number");
                bool equal = x == y;
                if (equal)
                {
                    Console.WriteLine("You entered eaual numbers");
                }
                else
                {
                    Console.WriteLine("You entered unequal numbers");

                }

            }
            static void checkGreaterNumber()
            {

                var x = cRL_P("Enter The First Number");
                var y = cRL_P("Enter The Second Number");
                bool equal = x > y;
                if (equal)
                {
                    Console.WriteLine("The First Number is greater than the second");
                }
                else
                {
                    Console.WriteLine("The First Number is smaller than the second");

                }

            }
            static void checkOddity()
            {
                int y;
                var x = Math.DivRem((int)cRL_P("Enter The  Number"), 2, out y);
                bool odd = y == 0;

                if (odd)
                {
                    Console.WriteLine("The Number is even");
                }
                else
                {
                    Console.WriteLine("The Number is odd");

                }

            }
            static void checkValue_10()
            {
                var x = cRL_P("Enter The  Number");
                bool condition = x == 10;
                if (condition)
                {
                    Console.WriteLine("The value is correct");
                }
                else
                {
                    Console.WriteLine("The value is wrong");

                }

            }

            static void checkTriangAbility()
            {
                var x = cRL_P("Enter The First Angle");
                var y = cRL_P("Enter The Second Angle");
                var z = cRL_P("Enter The Third Angle");
                bool condition = (x + y + z) == 180;
                if (condition)
                {
                    Console.WriteLine("The Angles can form Triangle");
                }
                else
                {
                    Console.WriteLine("The Angles can -not- form Triangle");

                }
            }



            static void checkGrade()
            {
                var x = cRL_P("Enter The Grade");

                if (x < 50 && x > 0)
                {
                    Console.WriteLine("Grade: Fail");
                }
                if (x >= 50 && x < 65)
                {
                    Console.WriteLine("Grade: Pass");
                }
                if (x >= 65 && x < 75)
                {
                    Console.WriteLine("Grade: Good");
                }
                if (x >= 75 && x < 85)
                {
                    Console.WriteLine("Grade: Very Good");
                }
                if (x >= 85 && x <= 100)
                {
                    Console.WriteLine("Grade: Excellent");
                }

            }
            static void gradeExpand()
            {

                Console.WriteLine("Enter The Grade 1st Letter");
                char x = char.ToUpper(char.Parse(Console.ReadLine()));

                if (x == 'F')
                {
                    Console.WriteLine("Grade: Fail");
                }
                if (x == 'P')
                {
                    Console.WriteLine("Grade: Pass");
                }
                if (x == 'G')
                {
                    Console.WriteLine("Grade: Good");
                }
                if (x == 'V')
                {
                    Console.WriteLine("Grade: Very Good");
                }
                if (x == 'E')
                {
                    Console.WriteLine("Grade: Excellent");
                }

            }
            static void getMonthDays()
            {
                string[] Months_ = new string[13];
                Months_[0] = "Null";
                Months_[1] = "Jan , 31 Days";
                Months_[2] = "Feb , 28 Days";
                Months_[3] = "Mar , 31 Days";
                Months_[4] = "April , 30 Days";
                Months_[5] = "May , 31 Days";
                Months_[6] = "Jun , 30 Days";
                Months_[7] = "Jul , 31 Days";
                Months_[8] = "Aug , 31 Days";
                Months_[9] = "Sep , 30 Days";
                Months_[10] = "Oct , 31 Days";
                Months_[11] = "Nov , 31 Days";
                Months_[12] = "Dec , 31 Days";
                var x = (int)cRL_P("Enter The month number");
                Console.WriteLine(Months_[x]);

            }
            static void getEquationRoots()
            {
                // reference https://en.wikipedia.org/wiki/Quadratic_equation
                // reference https://ar.wikipedia.org/wiki/%D9%85%D8%B9%D8%A7%D8%AF%D9%84%D8%A9_%D8%AA%D8%B1%D8%A8%D9%8A%D8%B9%D9%8A%D8%A9

                Console.WriteLine("aX^2 + bX + c= 0");
                var a = cRL_P("Enter a");
                var b = cRL_P("Enter b");
                var c = cRL_P("Enter c");
                double Discriminant = (Math.Pow(b, 2) - (4 * a * c));
                double x1, x2;

                if (Discriminant == 0)
                {
                    x1 = x2 = -b / 2.0 * a;

                    Console.Write("First  Root Root1= {0}\n", x1);
                    Console.Write("Second Root Root2= {0}", x2);
                }
                if (Discriminant > 0)
                {
                    x1 = (-b + Math.Sqrt(Discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(Discriminant)) / (2 * a);
                    Console.Write("First  Root Root1= {0}\n", x1);
                    Console.Write("Second Root Root2= {0}", x2);
                }
                else
                {
                    Console.WriteLine("There are no real roots. Rather, there are two distinct (non-real) complex roots");

                }
            }
        }
    }
}
