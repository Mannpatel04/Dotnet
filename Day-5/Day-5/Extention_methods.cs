using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    public static class StringExtentions
    {
        public static int WordCount(this string text)
        {
            return text.Split(' ').Length;
        }
    }



    internal class Extention_methods
    {
        public static void Main()
        {
            string messege = "This is Mann Signing in";
            int count =  messege.WordCount();
            Console.WriteLine(count);

         
        }
    }
}
