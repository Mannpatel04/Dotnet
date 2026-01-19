using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalc = new Calculator();

            Console.WriteLine("Calculator");
            myCalc.run();
            Console.ReadKey();
        }
    }

        internal class Calculator
        {
            public int option;
            public double result;
            public bool isCorrect;
            public double a, b;

            public void run()
            {
                int cases;

                Console.WriteLine("1) Enter 1 to perform arithmetic operations");
                Console.WriteLine("2) Enter 2 to perform compound assignment");
                Console.WriteLine("3) Enter 3 to perform comparison operations");

                string input = Console.ReadLine();
                if (int.TryParse(input, out cases))
                {
                    switch (cases)
                    {
                        case 1:
                            Console.WriteLine("Enter the first operand:");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter the second operand:");
                            b = Convert.ToDouble(Console.ReadLine());
                            arithmeticOperation(a, b);
                            Console.WriteLine($"Result of the operation is: {result}");
                            break;
                        case 2:
                            Console.WriteLine("Enter the initial value:");
                            a = Convert.ToDouble(Console.ReadLine());
                            compoundAssignment(a);
                            Console.WriteLine($"Result of the operation is: {result}");
                            break;
                        case 3:
                            Console.WriteLine("Enter the first operand:");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter the second operand:");
                            b = Convert.ToDouble(Console.ReadLine());
                            comparisonOperator(a, b);
                            Console.WriteLine($"Result of the operation is: {isCorrect}");
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please choose 1, 2, or 3.");
                            break;
                    }
                }
            }

            public void arithmeticOperation(double a, double b)
            {
                Console.WriteLine("1) + | 2) - | 3) * | 4) / | 5) %");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: result = a + b; break;
                    case 2: result = a - b; break;
                    case 3: result = a * b; break;
                    case 4: result = a / b; break;
                    case 5: result = a % b; break;
                    default: Console.WriteLine("Invalid operation"); break;
                }
            }

            public void compoundAssignment(double a)
            {
                Console.WriteLine("Enter the value to apply:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("1) += | 2) -= | 3) *= | 4) /= | 5) %=");

                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1: result = a += b; break;
                    case 2: result = a -= b; break;
                    case 3: result = a *= b; break;
                    case 4: result = a /= b; break;
                    case 5: result = a %= b; break;
                    default: Console.WriteLine("Invalid operation"); break;
                }
            }

            public void comparisonOperator(double a, double b)
            {
                Console.WriteLine("1) == | 2) <= | 3) >= | 4) < | 5) >");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: isCorrect = (a == b); break;
                    case 2: isCorrect = (a <= b); break;
                    case 3: isCorrect = (a >= b); break;
                    case 4: isCorrect = (a < b); break;
                    case 5: isCorrect = (a > b); break;
                    default: Console.WriteLine("Invalid operation"); break;
                }
            }
        }
}