using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_1
{
    internal class Task_3
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

            var Result = employee.Where(e => e.salary > 30000).Select(e =>new { e.Name, e.salary } ).OrderBy(e => e.salary );

            foreach(var e in Result)
            {
                Console.WriteLine($"{e.Name}:- {e.salary}");
            }
        }
    }
}


//Explaination:-
//In this file there is Orderby() used with Where() and select(). basically orderby() is used for the fordering of data.
//here in the salary column orderby() use for the arrange salary in ascending order.