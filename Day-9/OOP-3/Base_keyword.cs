using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{


    class Baseclass
    {
        public Baseclass()
        {
            Console.WriteLine("Default Constr of Baseclass");
        }

        public Baseclass(string name)
        {
            Console.WriteLine("Base class Parameterised Constructor.");
        }

    }


    class DerivedClass
    {
        public DerivedClass(string msg) : base()
        {
            Console.WriteLine("Derived class Constr" + msg);
        }
    }



    internal class Base_keyword
    {

        static void Main()
        {
            DerivedClass derive = new DerivedClass(" Login");
        }
          
    }
}
    

