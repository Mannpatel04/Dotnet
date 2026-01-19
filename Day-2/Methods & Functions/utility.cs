using System;

public static class MathUtility
{
    public static double Add(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;

    public static void GetCircleStats(double radius, out double area, out double circumference)
    {
        area = Math.PI * Math.Pow(radius, 2);
        circumference = 2 * Math.PI * radius;
    }

    public static double GetDivision(double dividend, double divisor, int precision = 2)
    {
        if (divisor == 0) return 0;

        double result = dividend / divisor;
        return Math.Round(result, precision);
    }
}


public class Program
{
    public static void Main()
    {
        double sum = MathUtility.Add(10.5, 20.5);
        Console.WriteLine("Sum:" + sum);

        MathUtility.GetCircleStats(5, out double myArea, out double myCircum);
        Console.WriteLine($"Area: {myArea:F2}, Circumference: {myCircum:F2}");

        double result1 = MathUtility.GetDivision(10, 3); 
        double result2 = MathUtility.GetDivision(10, 3, 4); 

        Console.WriteLine($"Default Precision: {result1}"); 
        Console.WriteLine($"Custom Precision: {result2}");  
    }
}
