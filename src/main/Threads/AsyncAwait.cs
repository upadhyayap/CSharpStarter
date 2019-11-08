using System.Threading.Tasks;
using System.Threading;
using System;
using System.Net;

namespace CSharpStarter.src.main.Threads
{
    public class AsyncAwait
    {
        public string Url {get; set;}
        public async Task<int> download(){
            Console.WriteLine($"Download started in Thread id {Thread.CurrentThread.ManagedThreadId}");
            WebClient webClient = new WebClient();
            byte[] data = await webClient.DownloadDataTaskAsync(Url).ConfigureAwait(false);
            Console.WriteLine("Await ended");

            Console.WriteLine($"Data Lenth is {data.Length}");

            Console.WriteLine($"Download Ended in Thread id {Thread.CurrentThread.ManagedThreadId}");

            return data.Length;
        }
    }
}