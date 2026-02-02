using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_1
{

    
    internal class Task_2
    {
        static void Main()
        {
            var employee = new[]
            {
                new {EmployeeID = 1, Name = "Mann", Department = "IT", Salary = 70000 },
                new {EmployeeID = 2, Name = "Ayush", Department = "HR", Salary = 22000 },
                new {EmployeeID = 3, Name = "Niken", Department = "HR", Salary = 56000 },
                new {EmployeeID = 4, Name = "Smit", Department = "IT", Salary = 80000 }
            };

            var Result = employee.Where(e => e.Department == "IT").Select(e => new { e.Name, e.Salary });

            foreach(var e in Result)
            {
                Console.WriteLine($"{e.Name}:- {e.Salary}");
            }

        }
    }
}


//Explaination:-
// In this project there is select() is used to pick specific field, create new objects.