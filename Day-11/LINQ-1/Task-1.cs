using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_1
{

    class Employee
    {
        public int Id;
        public string? Name;
        public double Salary;
        public string Department;
    }

    internal class Task_1
    {
        static void Main()
        {
            List<Employee> Employee = new List<Employee>()
            {
                new Employee{ Id = 1, Name = "Mann", Salary = 70000 },
                new Employee{ Id = 2, Name = "Ayush", Salary = 15000 },
                new Employee{ Id = 3, Name = "Niken", Salary = 6000 },
                new Employee{ Id = 4, Name = "Smit", Salary = 65000 },
            };

               var Result = Employee.Where(e => e.Salary > 25000);

            foreach (var e in Result)
            {
                Console.WriteLine($"{e.Name}:-{e.Salary}");   
            }
        }
    }
}



//Explaination:-
//In this program of filterinmg employee salary there is where() clause because it use for filter the collection and it returns  IEnumerable<Employee>.

