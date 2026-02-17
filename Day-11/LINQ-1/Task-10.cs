using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_1
{
    internal class Task_10
    {
        static void Main()
        {
            var employee = new[]
            {
                new {EmloyeeID = 1, Name = "Mann", salary = 40000},
                new {EmloyeeID = 1, Name = "Ayush", salary = 87000},
                new {EmloyeeID = 1, Name = "Niken", salary = 22000},
                new {EmloyeeID = 1, Name = "Smit", salary = 35000},
                new {EmloyeeID = 1, Name = "Om", salary = 29700},
            };

            //using Method Syntax
            var Result = employee.Select(e => new { e.Name, e.salary }).ToList();
            foreach (var item in Result)
            {
                Console.WriteLine($"Name:{item.Name} & Salary:{item.salary}");
            }

            //using Query Syntax
            //var result =
            //        (from e in employee
            //         select new
            //         {
            //             e.Name,
            //             e.salary
            //         }).ToList();

            //foreach (var item1 in result)
            //{
            //    Console.WriteLine($"Name:{item1.Name} Salary:{item1.salary}");

            //}




        }
    }
}

//in this program there is a query syntax which is use as same as method syntax but the key difference between is the syntax which we write in.
//Method query reads the program "employee → filter → select" and query syntax reads the program in the sql style.
