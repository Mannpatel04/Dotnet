using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_1
{
    internal class Task_9
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

            var names = employee.Select(x => x.Name).ToList();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}

//In this program we use select to print name and apply .ToList() to store the data in the List.