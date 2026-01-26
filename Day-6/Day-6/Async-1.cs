using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Day_6
{
    class Async_1
    {
        static async Task<string> ApiSim()
        {
            await Task.Delay(2000);
           
            return "Data received from API ";
        }

        static async Task Main()
        {
            Console.WriteLine("Calling API....");

            string result = await ApiSim();
            Console.WriteLine(result);
            Console.WriteLine("Program Finished");
        }

    }
}
