using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Day_6
{
    class FileDownloadSimulation
    {
        static void RunSynchronousDownload()
        {
            DownloadFileSync("File1");
            DownloadFileSync("File2");
            DownloadFileSync("File3");
        }

        static void DownloadFileSync(string fileName)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"{fileName} downloaded (Sync)");
        }

        static async Task RunAsynchronousDownload()
        {
            var task1 = DownloadFileAsync("File1");
            var task2 = DownloadFileAsync("File2");
            var task3 = DownloadFileAsync("File3");

            await Task.WhenAll(task1, task2, task3);
        }

        static async Task DownloadFileAsync(string fileName)
        {
            await Task.Delay(2000); 
            Console.WriteLine($"{fileName} downloaded (Async)");
        }

        static async Task Main()
        {
            Console.WriteLine("Synchronous Download Started...");
            var syncWatch = Stopwatch.StartNew();
            RunSynchronousDownload();
            syncWatch.Stop();
            Console.WriteLine($"Sync Time: {syncWatch.ElapsedMilliseconds} ms\n");

            Console.WriteLine("Asynchronous Download Started...");
            var asyncWatch = Stopwatch.StartNew();
            await RunAsynchronousDownload();
            asyncWatch.Stop();
            Console.WriteLine($"Async Time: {asyncWatch.ElapsedMilliseconds} ms");

            Console.WriteLine($"Async was {syncWatch.ElapsedMilliseconds / asyncWatch.ElapsedMilliseconds}x faster.");
        }
    }
}

