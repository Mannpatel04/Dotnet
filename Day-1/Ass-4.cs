using System;

namespace NullableExploration
{
    class Program
    {
        static void Main(string[] args)
        {

            int? optionalAge = null;
            long? optionalPhone = null;

            Console.WriteLine("Handling Optional User Data");


            if (optionalAge.HasValue)
            {
                Console.WriteLine($"Age: {optionalAge.Value}");
            }
            else
            {
                Console.WriteLine("Age: Not provided.");
            }


            string phoneDisplay = optionalPhone?.ToString() ?? "No phone number on file";
            Console.WriteLine($"Phone: {phoneDisplay}");

            Console.WriteLine("\n--- Updating Data ---");
            optionalAge = 25;

            Console.WriteLine(optionalAge.HasValue ? $"New Age: {optionalAge}" : "Age still null");
        }
    }
}