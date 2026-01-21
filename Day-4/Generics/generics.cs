class program
{
    static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }

    static void Main()
    {
        int a = 7;
        int b = 11;

        Console.WriteLine("before swap:");
        Console.WriteLine($"a = {a}, b = {b}");

        Swap(ref a, ref b);

        Console.WriteLine("After Swap:");
        Console.WriteLine($"a = {a}, b = {b}");
    }

}   