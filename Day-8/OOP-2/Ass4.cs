using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{

    interface ILogging
    {
        void Impliment();
    }
    interface IAuditing
    {
        void Impliment();
    }

    class Accounting : ILogging, IAuditing
    {
        void ILogging.Impliment()
        {
            Console.WriteLine("Implementing Logging interface");
        }

        void IAuditing.Impliment()
        {
            Console.WriteLine("Implimenting Auditing Interface");
        }
       
    }
    class Ass4
    {
        static void Main()
        {
            Accounting ac = new Accounting();


            //Method1
            //ILogging logger = ac;
            //logger.Impliment();

            //IAuditing auditing = ac;
            //auditing.Impliment();

            //Method2
            ((ILogging)ac).Impliment();
            ((IAuditing)ac).Impliment();

        }
    }
}
