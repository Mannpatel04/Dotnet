using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_1
{
    internal class Task_4
    {
        static void Main()
        {
            var employee = new[]
            {
                new {EmployeeID = 1, Name = "Mann", Department = "Dotnet"},
                new {EmployeeID = 2, Name = "Ayush", Department = "Devops"},
                new {EmployeeID = 3, Name = "smit", Department = "MERN"},
                new {EmployeeID = 4, Name = "Yash", Department = "Python"},
                new {EmployeeID = 5, Name = "Niken", Department = "Java"}

            };

            var Result = employee.OrderBy(e => e.Department).ThenBy(e => e.Name);

            foreach(var e in Result)
            {
                Console.WriteLine($"{e.Department}:-{e.Name}");
            }
        }
    }
}
