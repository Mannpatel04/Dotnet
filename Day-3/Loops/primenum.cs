

//Why For loop?:- Because we know the exact number of iterations in advance (from 1 to 100).
//               -for loop is ideal for such scenario when iteration is fixed.

class primeNumber {

     public static void Main(string[] args)
    {
        Console.WriteLine("Printing prime Number between 1 to 100:-");
        for (int i = 2; i <= 100; i++)
        {
            bool isprime = true;
            for (int j = 2; j < i; j++)
            {
                if (i%j ==0)
                {

                    isprime = false;
                    break;
                }
            }
            if (isprime)
            {
                Console.Write(i+ ",");
            }
        }
    }
}
