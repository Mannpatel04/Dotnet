using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{
    class Logger : IDisposable
    {
        StreamWriter writer;

        public Logger()
        {
            writer = new StreamWriter("log.txt");
        }

        public void WriteLog(string message)
        {
            writer.WriteLine(message);
        }

        public void Dispose()
        {
            writer.Close();
        }
    }
    internal class IDisposable_in_Action
    {
        static void Main()
        {
            using (Logger log = new Logger())
            {
                log.WriteLog("App started");
                log.WriteLog("Doing work");
            } 

            Console.WriteLine("File closed!");
        }

    }
}
