using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Linq_3
{
    internal class Task
    {
        static void Main()
        {


            #region Task-1
            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee{ EmployeeId=1, Name="Niken", Salary=25000, Department="HR"},
            //    new Employee{ EmployeeId=2, Name="Mann", Salary=40000, Department=".net"},
            //    new Employee{ EmployeeId=3, Name="Ayush", Salary=28000, Department="Java"}
            //};

            //var highSalaryEmployees = employees.Where(e => e.Salary > 30000);

            //employees.Add(new Employee
            //{
            //    EmployeeId = 4,
            //    Name = "Smit",
            //    Salary = 50000,
            //    Department = ">net"
            //});

            //foreach (var emp in highSalaryEmployees)
            //{
            //    Console.WriteLine($"{emp.Name} :- {emp.Salary}");
            //}

            //Why smit is added?:- "Due to differed query". it stored only query when you write the query and when you add people then list changes and foreach loop executes the updated list.
            //concept:- where() returns IEnumerable.
            #endregion

            #region Task-2

            //List<Student> students = new List<Student>()
            //{
            //    new Student{ RollNo=1, Name="Mann", Marks=35 },
            //    new Student{ RollNo=2, Name="Ayush", Marks=70 },
            //    new Student{ RollNo=3, Name="Niken", Marks=50 }
            //};
            //var storedResult = students.Where(s => s.Marks > 40).ToList();   // Immediate execution happens here

            //students.First(s => s.RollNo == 1).Marks = 80;
            //Console.WriteLine("Stored Result:");
            //foreach (var s in storedResult)
            //{
            //    Console.WriteLine($"{s.Name} :- {s.Marks}");
            //}

            //var freshQuery = students.Where(s => s.Marks > 40).ToList();

            //Console.WriteLine("\nFresh Query Result:");
            //foreach (var s in freshQuery)
            //{
            //    Console.WriteLine($"{s.Name} - {s.Marks}");
            //}

            //Why this happens when Mann is not added in the Stored result but added in first query?:- because of immediate Execution due to ToList().
            // generallt TOList() Method stored the result and execute the query. so updated data may not added.
            //Imediate Execution happens when we have this methods:- ToList(), ToArray(), Count(), First(), Sum().









            #endregion

            #region Task-3
            //var orders = new List<Order>
            //{
            //  new Order
            //  {
            //    OrderID = 1,
            //    CustomerName = "Mann",
            //    OrderItems = new List<OrderItem>
            //    {
            //      new OrderItem { ProductName = "Iphone", ProductPrice = 78000 },
            //      new OrderItem { ProductName = "Ipad", ProductPrice = 50000 }
            //     }
            //  },
            //  new Order
            //  {
            //     OrderID = 2,
            //     CustomerName = "Aayush",
            //     OrderItems = new List<OrderItem>
            //     {
            //       new OrderItem { ProductName = "Laptop", ProductPrice = 56000 }
            //      }
            //  } 
            //};

            //var products = orders
            //    .SelectMany(o => o.OrderItems)//Flattens The collection
            //    .Select(i => i.ProductName);

            //Console.WriteLine("All Product Name:-");
            //foreach (var name in products)
            //{
            //    Console.WriteLine(name);
            //}

            //int totalProducts = orders
            //            .SelectMany(o => o.OrderItems)
            //            .Count();

            //Console.WriteLine($"\nTotal Products Sold: {totalProducts}");


            //Why SelectMany is Needed:- because if we use select it gives this type of output: [
            //                                                                                        [Laptop, Mouse],
            //                                                                                        [Keyboard, Monitor]
            //                                                                                  ]
            // This is the nested list which is hard to loop.And if we use selectMany than it flattens List and give the following Output: Laptop, Mouse, Keyboard, Monitor
            //Basically Select gives us a collection and selectMany Flateens all collection into the single sequence.



            #endregion

            #region Task-4

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee{ EmployeeId=1, Name="Niken",  Department="HR"},
            //    new Employee{ EmployeeId=2, Name="Mann",  Department=".net"},
            //    new Employee{ EmployeeId=3, Name="Ayush",  Department=".net"},
            //    new Employee{ EmployeeId=4, Name="OM",  Department="Java"},
            //    new Employee{ EmployeeId=5, Name="Smit",  Department="Java"},
            //    new Employee{ EmployeeId=6, Name="Vishwa",  Department="MERN"}

            //};

            //var result = employees
            //    .GroupBy(e => e.Department)
            //    .Select(g => new
            //    {
            //        Department = g.Key,
            //        Count = g.Count()
            //    });//Not Executed yet

            //employees.Add(new Employee { EmployeeId = 7, Name = "Het", Department = "MERN" });//Row added

            //foreach (var i in result)
            //{
            //    Console.WriteLine($"{i.Department} :- {i.Count}");//Executed Here: Prints with Updated data.

            //}

            //Execution Type: Differed Execution. Because the GroupBy() and Select() returns IEnumerable that do not Executes immediately.
            //Because query runs at enumeration time, not when written.


            #endregion

            #region Task-5
            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee{ EmployeeId=1, Name="Niken", Salary=25000, Department="HR"},
            //    new Employee{ EmployeeId=2, Name="Mann", Salary=40000, Department=".net"},
            //    new Employee{ EmployeeId=3, Name="Ayush", Salary=28000, Department="Java"}
            //};

            //IEnumerable<Employee> result = employees.Where(e => e.Salary > 30000);
            // foreach(var e in result)
            //{
            //    Console.WriteLine($"{e.Name}");
            //}
            //IQueryable<Employee> Result = employees.AsQueryable().Where(f => f.Salary > 30000);
            //foreach (var e in result)
            //{
            //    Console.WriteLine($"{e.Name}");
            //}

            /* Write the difference between IEnumerable and IQueryable in simple words.
             - IEnumerable<> - It loads the data in memory(Ram).
                             - It Fetch the all data and then it filters.
                             - It Slower for large amount of data.
                             - execution place at Client Side.
             - IQueryable<> - It runs the Query directly on DB server. 
                            - It runs query on DB and and retuns the filtered data, in simple word it fetch the data after filtering.
                            - It faster for large amount of data.
                            - execution place at server side.
            */

            #endregion

            #region Task-6
            //var employee = new List<Employee>()
            //{
            //    new Employee {EmployeeId = 1, Name = "Mann", DepartmentId = 1, },
            //    new Employee {EmployeeId = 2, Name = "Aayush",DepartmentId = 1,},
            //    new Employee {EmployeeId = 3, Name = "Niken", DepartmentId = 2,},
            //    new Employee {EmployeeId = 4, Name = "Smit", DepartmentId = 4, },
            //    new Employee {EmployeeId = 5, Name = "Om",  DepartmentId = 5,  },
            //    new Employee {EmployeeId = 6, Name = "Ayush",DepartmentId = 3, },
            //};

            //var department = new List<Department>()
            //{
            //    new Department {DepartmentId = 1, DepartmentName = ".Net"},
            //    new Department {DepartmentId = 2, DepartmentName = "Java"},
            //    new Department {DepartmentId = 3, DepartmentName = "Devops"},
            //    new Department {DepartmentId = 4, DepartmentName = "MERN"},
            //    new Department {DepartmentId = 5, DepartmentName = "Python"},
            //};

            ////Wrong way 
            //var result = employee.Select(e => new { EmpolyeeName = e.Name, DepartmentName = department.Where(d=> d.DepartmentId  == e.DepartmentId).Select(d=> d.DepartmentName).FirstOrDefault()});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.EmpolyeeName} - {item.DepartmentName}");
            //}
            ////correct way
            //var Result = employee
            //     .Join(department,
            //           e => e.DepartmentId,
            //           d => d.DepartmentId,
            //           (e, d) => new
            //           {
            //               EmployeeName = e.Name,
            //               DepartmentName = d.DepartmentName
            //           });
            //Console.WriteLine("");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.EmpolyeeName} - {item.DepartmentName}");
            //}

            /*
             - Explain what N+1 problem is and w.
             => N+1 problem occurs when an application first loads a list of records (1 query) and then executes an additional query for each record (N queries), causing many unnecessary database calls.

             - Why it is bad? - because of too many database calls and it slows the performance because of this it gives high load on server, poor scalability.
             - Using Join or Include fetches everything in a single query and avoids this issue.
             */

            #endregion

            #region Task-7
            //List<Product> products = new List<Product>
            //{
            //    new Product{ProductId=1,ProductName="Laptop"},
            //    new Product{ProductId=2,ProductName="Mouse"},
            //    new Product{ProductId=3,ProductName="Keyboard"},
            //    new Product{ProductId=4,ProductName="Mouse"},
            //    new Product{ProductId=5,ProductName="Laptop"}
            //};

            //int beforeCount = products.Count;
            //Console.WriteLine($"Before Count: {beforeCount}");

            //var uniqueNames = products
            //        .Select(p => p.ProductName)
            //        .Distinct()
            //        .ToList();//Immediate Execution

            //Console.WriteLine("\nUnique Products:");

            //foreach (var name in uniqueNames)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine($"\nAfter Count: {uniqueNames.Count}");

            //LINQ Method Used:-Distinct(), Select(), ToList();
            //Distinct() : Because this method gives us only Unique value.
            //Select() : To select the column of the productName.
            //ToList() : Do the Immediate Execution, In this problem we want to show the before and after count of product so when we store the list of uniqueNames then execute it immediatly.



            #endregion

            #region Task-8
            //List<Employee> employees = new List<Employee>
            //{
            //    new Employee{ EmployeeId = 1, Name = "Mann" },
            //    new Employee{ EmployeeId = 2, Name = "Ayush" },
            //    new Employee{ EmployeeId = 3, Name = "Niken" }
            //};

            //var empDictionary = employees.ToDictionary(e=> e.EmployeeId, e=>e.Name);

            //foreach (var i in empDictionary)
            //{
            //    Console.WriteLine($"Key: {i.Key}, Value: {i.Value}");
            //}

            //LINQ Method:- ToDictionary() 
            //Why:- because it stored the data as data stored in dictionary that is key value pair, basically it convert the collection type to Dictionary.
            // Why it is Immediate execution Method: It executes Immediatly because of it has to traverse to entire list and store the as a key value pair in Memory. so execution cannot be delayed.

            #endregion

            #region Task-9
            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee{ EmployeeId=1, Name="Niken",  Department="HR"},
            //    new Employee{ EmployeeId=2, Name="Mann",  Department="IT"},
            //    new Employee{ EmployeeId=3, Name="Ayush",  Department="IT"},
            //    new Employee{ EmployeeId=4, Name="OM",  Department="Embedded"},
            //    new Employee{ EmployeeId=5, Name="Smit",  Department="Embedded"},
            //    new Employee{ EmployeeId=6, Name="Vishwa",  Department="Digital Marketing"}

            //};

            //var itEmployees = employees
            //        .Where(e => e.Department == "IT");

            //Console.WriteLine("First Print:");
            //foreach (var e in itEmployees)
            //{
            //    Console.WriteLine(e.Name);
            //}

            //Console.WriteLine("\nSecond Print:");
            //foreach (var e in itEmployees)
            //{
            //    Console.WriteLine(e.Name);
            //}

            //employees[1].Department = "HR";   //Mann moved to HR

            //Console.WriteLine("\nAfter Update:");
            //foreach (var e in itEmployees)
            //{
            //    Console.WriteLine(e.Name);
            //}

            //Why this is happens?:- because where() uses Deferred Execution, Query is not stored as result but query Logic is stored each foreach loop re-runs after filter.
            //Basically in simple language whenever query uses Deferred Execution then it re-evaluate the query and gives a Live data.


            #endregion

            #region Task-10
            /* 
             -Use of ToList():- Use ToList() when we need the snapshot, generally LINQ query use  Deferred execution thats why whenever the foreach loop runs then it re-evaulates the entire query and gives Live result to despite this this method tack snapshot of data when it calls and store the fixed copy.
                              -In simplw words use this when you have multiple loops and avoid re-running heavy queries and wants Stable results.

            -Avoid multiple enumeration:- to avoid multiple enumeration like foreach loop re-runs the same query use the ToList() method as mention Above.

            -Use Any() instead of Count() >0 - because Count() checks ALL elements and Any() stops after its first match.
                                             - it is faster and more efficient when it comes to large collection and databases.

            -Avoid loops if LINQ is possible - because LINQ make code more readable, shorter, cleaner and declaration is easy instead of loops.

            -N+1 query problem - 
             */
            #endregion



        }
    }
}
