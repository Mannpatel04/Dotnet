using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOP_3
{

    abstract class Employee
    {

        public int BasicSalary;
        public int Bonus;
        public int PF;
        public int Month_pay;
        public int Month;
        public int Yearly;
       
      
        public abstract void Salary();
        
    }

    class FullTimeEmployee : Employee
    {
         int FinalSalary;

        public override void  Salary()
        {
            FinalSalary = (BasicSalary + Bonus) - PF;
            Yearly = FinalSalary*12;


            Console.WriteLine($"Monthly  Package is {Yearly}");
        }
    }

    class ContractEmployee : Employee 
    {
        int FinalSalary;

        public override void Salary()
        {
            FinalSalary = Month_pay * Month;
            Console.WriteLine($"The {Month} month salary is {FinalSalary}");
        }
    }


    internal class EmployeeHierarchy
    {
        static void Main()
        {
           
       
            Employee emp = new FullTimeEmployee();

            emp.BasicSalary = 15000;
            emp.Bonus = 8000;
            emp.PF = 3600;
            emp.Salary();



            Employee C_emp = new ContractEmployee();
            C_emp.Month_pay = 7000;
            C_emp.Month = 8;
         
            C_emp.Salary();

          

        }
    }
}
