using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_1
{
    internal class Task_6
    {
        static void Main()
        {

            var employee = new[]
           {
                new {EmployeeID = 1, Name = "Mann", Department = "IT", city = "Surendranagar" },
                new {EmployeeID = 2, Name = "Ayush", Department = "HR", city = "Surendranager" },
                new {EmployeeID = 3, Name = "Niken", Department = "HR", city = "Mahesana" },
                new {EmployeeID = 4, Name = "Smit", Department = "IT", city = "Ahmedabad"}
            };

            var Result = employee.Select(x => new
            {
                x.Name,
                x.Department,
                x.city
            });

            foreach(var x in Result)
            {
                Console.WriteLine($"Name:-{x.Name}, Department:-{x.Department}, City:-{x.city}");
            }
        }
    }
}

//Explaination:-
//In this program select is used for select the column of name, department, city.