using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_1
{

    class Order
    {
        public int OrderID;
        public string CustomerName;
        public List<OrderItem> OrderItems;
    }

    class OrderItem
    {
        public string ProductName; 

        public int ProductPrice; 
    }


    internal class Task_7_8
    {
        public static void Main()
        {
            var orders = new List<Order>
            {
              new Order
              {
                OrderID = 1,
                CustomerName = "Mann",
                OrderItems = new List<OrderItem>
                {
                  new OrderItem { ProductName = "Iphone", ProductPrice = 78000 },
                  new OrderItem { ProductName = "Ipad", ProductPrice = 50000 }
                 }
            },
              new Order
              {
                 OrderID = 2,
                 CustomerName = "Aayush",
                 OrderItems = new List<OrderItem>
                 {
                   new OrderItem { ProductName = "Laptop", ProductPrice = 56000 }
                  }
             }
        };

            // Task 7
            //var products = orders
            //    .SelectMany(o => o.OrderItems)
            //    .Select(i => i.ProductName);

            //foreach (var name in products)
            //    Console.WriteLine(name);


            //Task 8
            var result = orders
                           .SelectMany(
                               o => o.OrderItems,
                              (o, item) => new
                              {
                                CustomerName = o.CustomerName,
                                ProductName = item.ProductName
                              });

            foreach (var o in result)
            {
                Console.WriteLine($"{o.CustomerName} - {o.ProductName}");
            }


            //Explaination:-
            //selectMany() is used for projects each element into a collection and then flattens all those collections into a single sequence.
            //Insort SelectMany converts one-to-many data into one flat list.











        }
    }
}
