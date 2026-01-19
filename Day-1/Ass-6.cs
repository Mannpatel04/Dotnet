using System;

namespace ConstVsReadonly
{
    class Order
    {
        public const double TaxRate = 0.08;
        public readonly string OrderId;

        public Order(string id)
        {
            OrderId = id;
        }

        public void AttemptModification(){}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order("ORD-12345");

            Console.WriteLine($"Order ID: {myOrder.OrderId}");
            Console.WriteLine($"Tax Rate: {Order.TaxRate}");

        }
    }
}