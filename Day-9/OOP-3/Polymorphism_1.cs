using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{


    class PaymentProcessor
    {
        public void ProcessPayment(int a)
        {
            Console.WriteLine($"Method overloading with one passed parameter:{a} ");
        }

        public void ProcessPayment(double a, double b)
        {
            Console.WriteLine($"Method overloading with Two passed parameter:{a} and {b}");
        }

        public virtual void PaymentBehaviour()
        {
            Console.WriteLine("Base class Payment behaviour");
        }
    }


    class CreditCard : PaymentProcessor
    {
        public override void PaymentBehaviour()
        {
            Console.WriteLine("Payment via Credit Card");
        }
    }

    class UPI : PaymentProcessor
    {
        public override void PaymentBehaviour()
        {
            Console.WriteLine("Payment via UPI");
        }
    }
    internal class Polymorphism_1
    {
        static void Main()
        {

            //overloading
            PaymentProcessor processor = new PaymentProcessor();
            processor.ProcessPayment(7);
            processor.ProcessPayment(7, 11);

            CreditCard card = new CreditCard();
            card.PaymentBehaviour();//overriding

            UPI upi = new UPI();
            upi.PaymentBehaviour();//overriding

        }
    }
}
