using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    internal class Delegates
    {
        delegate void MyDelegate(string message);

        static void Sayhello(string msg)
        {
            Console.WriteLine("Hello!!!" + msg);
        }

        static void Saybyy(string msg)
        {
            Console.WriteLine("byyyy..." + msg);
        }

        static void Main()
        {
            MyDelegate dl = new MyDelegate(Sayhello);
            dl += Saybyy;
            dl("Mann");
        }


    }
}
