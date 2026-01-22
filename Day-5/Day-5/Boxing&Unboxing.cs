using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    internal class Boxing_Unboxing
    {

        public static void Main()
        {
            int num = 123;
            Console.WriteLine("Value type before boxing:"+ num);

            object obj = num;//boxing
            Console.WriteLine("boxing_value:" + obj);

            int unboxed = (int)obj;//unboxing
            Console.WriteLine("unboxing_value:" + unboxed);

        }
       

    }
}
