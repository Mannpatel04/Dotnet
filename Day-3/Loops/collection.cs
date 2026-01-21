
//Why Foreach?:-Best for collections and arrays
//             - No need to manage indexes
//             - Cleaner, safer, and more readable.


class foreachexample
{
    static void Main()
    {
        List<string> Mobile = new List<string>
        {
            "Samsung",
            "Oneplus",
            "Vivo",
            "Oppo",
            "Motorola"
        };

        Console.WriteLine("Mobiles:");

        foreach(string mobiles in Mobile)
        {
            Console.Write(mobiles + ", ");
        }

    }
}