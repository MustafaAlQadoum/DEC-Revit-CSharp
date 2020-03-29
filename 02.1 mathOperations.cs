using System;

namespace CourseAssignment1
{


    internal class mathOperations
    {
        private static void Main(string[] args)
        {

            const float Pi = 3.14f;
            Console.ForegroundColor = ConsoleColor.Red;
            //  Console.WriteLine(var_1 * 2);
            Console.WriteLine("Choose The Operation you want to do");
            Console.WriteLine("1. Sum two numbers");
            Console.WriteLine("2. Get Circle Area");
            Console.WriteLine("3. Get Rectangle Area");
            Console.WriteLine("4. Get Triangle Area");
            Console.WriteLine("5. Math Operations");
            Console.WriteLine("6. Get Dividing Remineder Over 2");
            Console.WriteLine("7. Get Mltiplication table from 1 to 5");
            Console.WriteLine("8. Get the mean of 5 numbers");
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
                        sumNumbers();
                        break;

                    case 2:
                        // 02   Second Task
                        getCircleArea();
                        break;

                    case 3:
                        // 03   Third Task
                        getRecatArea();
                        break;

                    case 4:
                        // 04   Fourth Task
                        getTriArea();
                        break;

                    case 5:
                        // 05   Fifth Task
                        intMathOperations();
                        break;

                    case 6:
                        // 06   Sixth Task
                        divReminder();
                        break;

                    case 7:
                        // 07   Seventh Task
                        multiTable();
                        break;

                    case 8:
                        // 08   Eighth Task
                        _5numbersMean();
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
            // Functions 
            static void sumNumbers()
            {
                var x = cRL_P("Enter 1st number");
                var y = cRL_P("Enter 2nd number");
                cWL_P(x + y);
            }
            static void getCircleArea()
            {
                var x = cRL_P("Enter The Circle Radious");
                cWL_P(Math.Round((Math.Pow(x, 2) * Pi), 2));
            }
            static void getRecatArea()
            {
                var x = cRL_P("Enter The Rectangle Length");
                var y = cRL_P("Enter The Rectangle Width");
                cWL_P(x * y);
            }
            static void getTriArea()
            {
                var x = cRL_P("Enter The Triangle Base Length");
                var y = cRL_P("Enter The Triangle Height");
                cWL_P(x / 2 * y);
            }
            static void intMathOperations()
            {
                var x = cRL_P("Enter The First Number");
                var y = cRL_P("Enter The Second Number");
                Console.WriteLine("Sum"); cWL_P(x + y);
                Console.WriteLine("Sub"); cWL_P(x - y);
                Console.WriteLine("Mul"); cWL_P(x * y);
                Console.WriteLine("Div"); cWL_P(x / y);
            }
            static void multiTable()
            {
                var x = cRL_P("Enter The Number To get Mltiplication table from 1 to 5");
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(x + " * " + i); cWL_P(x * i);
                }
            }
            static void divReminder()
            {
                var x = cRL_P("Enter The Number To get the Dividing Reminder over 2");
                cWL_P(x % 2);
            }
            static void _5numbersMean()
            {
                var x = cRL_P("Enter The 1st Number ");
                var y = cRL_P("Enter The 2nd Number ");
                var z = cRL_P("Enter The 3rd Number ");
                var xx = cRL_P("Enter The 4th Number ");
                var yy = cRL_P("Enter The 5th Number ");
                cWL_P((x + y + z + xx + yy) / 5);
            }
        }
    }
}