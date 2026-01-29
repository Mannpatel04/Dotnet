using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{

    class Calculator
    {
        public virtual void Addition(int a, int b)
        {
            Console.WriteLine($"Addition of two number:{a + b}");
        }
        public void Info()
        {
            Console.WriteLine("Basic Calculator");
        }
    }

    class AdvanceCalculator : Calculator
    {
        public override void Addition(int a, int b)
        {
            Console.WriteLine($"Addition in the Advance calculator: {a + b}");

        }

        public new void Info()
        {
            Console.WriteLine("Advance calculator");
        }

        internal class Method_hiding
        {

            static void Main()
            {
                Calculator c = new Calculator();
                AdvanceCalculator ac = new AdvanceCalculator();

                Console.WriteLine("Base class Reference");
                c.Addition(7, 11);
                c.Info();
                Console.WriteLine();
                Console.WriteLine("Derive class reference");
                ac.Addition(7, 4);
                ac.Info();

            }
        }
    }
}
