using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{


    #region Encapsulation
    class Employee
    {
        private int salary;//field

        public string Name { get; set; }//property
        
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value <0)
                {
                    Console.WriteLine("Not valid salary");
                    return;
                }
                salary = value;
            }
        }
    }
    #endregion

    #region Abstraction
     
    abstract class Movies
    {
        abstract public void genere();


    }

    class SciFi : Movies
    {
        public override void genere()
        {
            Console.WriteLine("This is Sci-Fi Genere Movie");
        }

    }

    #endregion

    #region Interface
    interface Payment
    {
        void pay();// by defalult Public
    }

    class CreditacardPay : Payment
    {
        public void pay()
        {
            Console.WriteLine("Payment via credit card");
        }
    }

    class CashPay : Payment
    {
        public void pay()
        {
            Console.WriteLine("Payment via Cash");
        }
    }

    #endregion


     class A
    {
         static A()
        {
            Console.WriteLine("scpodskcnsdc");

        }
    }
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            Employee emp = new Employee();
            emp.Name = "Mann Badreshiya";
            emp.Salary = 25000;

            Console.WriteLine($"{emp.Name}, {emp.Salary}");
            #endregion

            #region Abstraction
            Movies mv = new SciFi();
            mv.genere();
            #endregion

            #region interface
            CreditacardPay crp = new CreditacardPay();
            crp.pay();
            CashPay cp = new CashPay();
            cp.pay();
            #endregion


            Console.WriteLine("ijhdskn dcscijok");
            A a = new A();  
        }
    }
}
