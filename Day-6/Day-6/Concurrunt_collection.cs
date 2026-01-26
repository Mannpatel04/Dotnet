using System;
using System.Collections.Concurrent;
namespace Day_6
{
    class Concurrunt_collection
    {
        static ConcurrentQueue<string> logQueue = new ConcurrentQueue<string>();

        static void UserOneActivity()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(150);
                string log = $"User1 action {i}";
                logQueue.Enqueue(log);
                Console.WriteLine($"[Thread {Thread.CurrentThread.ManagedThreadId}] Enqueued: {log}");
            }
        }

        static void UserTwoActivity()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(150);
                string log = $"User2 action {i}";
                logQueue.Enqueue(log);
                Console.WriteLine($"[Thread {Thread.CurrentThread.ManagedThreadId}] Enqueued: {log}");
            }
        }

        static void Main()
        {
            Thread t1 = new Thread(UserOneActivity);
            Thread t2 = new Thread(UserTwoActivity);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("\nProcessing Logs:");

            while (logQueue.TryDequeue(out string log))
            {
                Console.WriteLine(log);
            }
        }
    }
}
