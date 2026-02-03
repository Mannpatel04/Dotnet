using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_2
{
    internal class Task
    {
        static void Main()
        {

            #region Task-1
            //var employee = new List<Employee>()
            //{
            //    new Employee {EmployeeId = 1, Name = "Mann", Department = ".Net", Salary = 90000},
            //    new Employee {EmployeeId = 2, Name = "Aayush", Department = ".Net", Salary = 45000},
            //    new Employee {EmployeeId = 3, Name = "Niken", Department = "Java", Salary = 89000},
            //    new Employee {EmployeeId = 4, Name = "Smit", Department = "MERN", Salary = 65000},
            //    new Employee {EmployeeId = 5, Name = "Om", Department = "MERN", Salary = 50000},
            //    new Employee {EmployeeId = 6, Name = "Ayush", Department = "Devops", Salary = 100000},
            //};

            //var HighestSalary = employee.Select(e => e.Salary).Max();// Max() for the highest salary
            //Console.WriteLine($"Highest salary: {HighestSalary}");

            //var LowestSalary = employee.Select(e => e.Salary).Min();//Min() for the Lowest salary
            //Console.WriteLine($"Lowest salary: {LowestSalary}");

            //var TotalSalary = employee.Select(e => e.Salary).Sum();//Sum() for the Total salary
            //Console.WriteLine($"Total salary: {TotalSalary}");

            //var averageSalary = employee.Select(e => e.Salary).Average();//Average() for the Average of the salary
            //Console.WriteLine($"Average salary: {averageSalary}");


            ////In this problem I have to do grouping of the department so I use the groupby(). and select for the selection or projection of data g.key prints name and count for the counting of employee that how many employee work here.
            //var NoOfEmployee = employee.GroupBy(e => e.Department).Select(g => new { Department = g.Key, count = g.Count() });
            //foreach(var item in NoOfEmployee)
            //{
            //    Console.WriteLine($"\n{item.Department} Department : {item.count} employee");
            //}
            #endregion

            #region Task-2
            //var employee = new List<Employee>()
            //{
            //    new Employee {EmployeeId = 1, Name = "Mann", DepartmentId = 1, Salary = 90000},
            //    new Employee {EmployeeId = 2, Name = "Aayush",DepartmentId = 1, Salary = 45000},
            //    new Employee {EmployeeId = 3, Name = "Niken", DepartmentId = 2, Salary = 89000},
            //    new Employee {EmployeeId = 4, Name = "Smit", DepartmentId = 4, Salary = 65000},
            //    new Employee {EmployeeId = 5, Name = "Om",  DepartmentId = 5,Salary = 50000},
            //    new Employee {EmployeeId = 6, Name = "Ayush",DepartmentId = 3,  Salary = 100000},
            //};

            //var department = new List<Department>()
            //{
            //    new Department {DepartmentId = 1, DepartmentName = ".Net"},
            //    new Department {DepartmentId = 2, DepartmentName = "Java"},
            //    new Department {DepartmentId = 3, DepartmentName = "Devops"},
            //    new Department {DepartmentId = 4, DepartmentName = "MERN"},
            //    new Department {DepartmentId = 5, DepartmentName = "Python"},
            //};

            ////Method syntax:-
            //var result = employee.Join(
            //    department,
            //    emp =>emp.DepartmentId,
            //    dept => dept.DepartmentId,
            //    (emp, dept) => new
            //    {
            //        emp.Name,
            //        dept.DepartmentName
            //    }
            //    );

            //Console.WriteLine("Inner Join:-");
            //Console.WriteLine("");

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Name} is from {item.DepartmentName}");
            //}
            //Console.WriteLine("");
            //Console.WriteLine("Group Join:-");
            //Console.WriteLine("");

            //var Result = department.GroupJoin(
            //     employee,
            //     dept => dept.DepartmentId,
            //     emp => emp.DepartmentId,
            //     (dept, empGroup) => new
            //     {
            //         Department = dept.DepartmentName,
            //         employee = empGroup
            //     }
            //     );
            //foreach (var dept in Result)
            //{
            //    Console.WriteLine($"{dept.Department} :-");
            //    foreach (var emp in dept.employee)
            //    {
            //        Console.WriteLine("  " + emp.Name);
            //    }
            //}


            //Explaination:-
            //Join:- I used this for the join of two table. bassically it is inner join.where it retuns only commen values
            //Group join:-
            #endregion

            #region Task-3
            //var employee = new List<Employee>()
            //{
            //    new Employee {EmployeeId = 1, Name = "Mann", Department = ".Net", Salary = 90000},
            //    new Employee {EmployeeId = 2, Name = "Aayush", Department = ".Net", Salary = 45000},
            //    new Employee {EmployeeId = 3, Name = "Niken", Department = "Java", Salary = 89000},
            //    new Employee {EmployeeId = 4, Name = "Smit", Department = "MERN", Salary = 65000},
            //    new Employee {EmployeeId = 5, Name = "Om", Department = "MERN", Salary = 50000},
            //    new Employee {EmployeeId = 6, Name = "Ayush", Department = "Devops", Salary = 100000},
            //};

            //var result = employee.GroupBy(e => e.Department).Select(M => new
            //{
            //    Department = M.Key,
            //    AverageSalary = M.Average(e => e.Salary),
            //    Totalemp = M.Count()
            //});

            //foreach (var e in result)
            //{
            //    //Console.WriteLine($"{e.Department} Has AverageSalary: {e.AverageSalary} And  {e.Totalemp}  Employee");
            //   // Console.WriteLine(e);
            //}

            //Explaination:-
            //Groupby:- Generally it is used for the grouping of the data. in this task i used this for the group of department.
            //count:- count is use the total count of the row.
            #endregion

            #region Task-4
            //var employee = new List<Employee>()
            //{
            //    new Employee {EmployeeId = 1, Name = "Mann", Department = ".Net", Salary = 90000},
            //    new Employee {EmployeeId = 2, Name = "Aayush", Department = ".Net", Salary = 45000},
            //    new Employee {EmployeeId = 3, Name = "Niken", Department = "Java", Salary = 89000},
            //    new Employee {EmployeeId = 4, Name = "Smit", Department = "MERN", Salary = 22000},
            //    new Employee {EmployeeId = 5, Name = "Om", Department = "MERN", Salary = 50000},
            //    new Employee {EmployeeId = 6, Name = "Ayush", Department = "Devops", Salary = 100000},
            //    new Employee {EmployeeId = 7, Name = "Het", Department = "HR", Salary = 30000},
            //    new Employee {EmployeeId = 8, Name = "Raj", Department = "HR", Salary = 80000},
            //};

            //var AverageSalary = employee.Average(e => e.Salary);

            //var result1 = employee.Where(e => e.Salary > AverageSalary);

            //foreach (var e in result1)
            //{
            //    Console.WriteLine($"{e.Name} has salary grater than Average salary");

            //}

            //var hrMaxSalary = employee.Where(e => e.Department == "HR").Max(e => e.Salary);
            //var result2 = employee.Where(e => e.Salary > hrMaxSalary).ToList();
            //Console.WriteLine("");
            //foreach (var M in result2)
            //{
            //    Console.WriteLine($"{M.Name} Has more than HR Max salary");

            //}



            //Explaination:-
            //Average:-it average the salary of the employees.
            //
            #endregion

            #region Task 5
            //var list1 = new List<int>() { 07, 11, 20, 28 };
            //var list2 = new List<int>() { 11, 23, 28, 07 };


            //var common = list1.Intersect(list2);
            //Console.WriteLine("common integers:-");
            //foreach (var name in common)
            //{

            //    Console.WriteLine(" "+name);
            //}

            //var only_first = list1.Except(list2);
            //Console.WriteLine("integer which is only in list1");

            //foreach (var first in only_first)
            //{
            //    Console.WriteLine(" "+first);
            //}


            //var combined = list1.Union(list2);
            //Console.WriteLine("combined the element of both list");

            //foreach (var comb in combined)
            //{
            //    Console.WriteLine(" "+comb);
            //}


            //Explaination:-
            //intersect:- it retrives the common data from the both lists.
            //Except:- it gives a list of data which are not present in the comparatively opposite list.
            //union:- it gives union of data and gives a list of combined data.
            #endregion


        }
    }
}
