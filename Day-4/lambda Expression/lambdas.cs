using System;
using System.Collections.Generic;

class program
{
    static void Main()
    {

        //filter even numbers
        int[] numbers = { 10, 15, 48, 35, 89, 73, 66 };
      

        var evenNumbers = (int[] numbers) =>
        {
            List<int> result = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }

            }
            return result;
        };

        List<int> result = evenNumbers(numbers);
        Console.WriteLine("Even numbers:");

        foreach (int item in result)
        {
            
            Console.WriteLine(item);
        }



        //find MAX value

        var maxValue = (int[] numbers) =>
        {

            int temp = numbers[0];
            foreach (int item in numbers)
            {
                if (temp < item)
                {
                    temp = item;
                }

            }
            return temp;
        };

        int maximumNumber = maxValue(numbers);
        Console.WriteLine("Maximum value:" + maximumNumber);



        //sort a collection
        Console.WriteLine("Sorted numbers:");
        numbers = numbers.OrderBy(n => n).ToArray();
        Array.ForEach(numbers, n => Console.WriteLine(n));

    }
}