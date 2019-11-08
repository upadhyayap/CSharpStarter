using System.Threading;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Net;
namespace CSharpStarter.src.main.Threads
{
    public class AsyncIOWithTask
    {
        public string Url { get; set; }
        // public AsyncIOWithTask(string url)
        // {
        //     this.Url = url;
        // }

        public void Download()
        {
            Console.WriteLine($"Starting Download in thread id {Thread.CurrentThread.ManagedThreadId}");
            
            var httpWebRequest = HttpWebRequest.CreateHttp(Url);
            Task<WebResponse> httpRequestTask = httpWebRequest.GetResponseAsync();
            Task httpResponseContinuation = httpRequestTask
                    .ContinueWith(_HttpContinuationTask, TaskContinuationOptions.OnlyOnRanToCompletion);

            Task.WaitAll(httpRequestTask, httpResponseContinuation);

            Console.WriteLine($"Done Download");
        }

        public void DoInParallel(){
            Parallel.For(1, 100, (iteration) => Console.WriteLine(iteration));
        }

        private void _HttpContinuationTask(Task<WebResponse> taskResponse) {
            var result = taskResponse.Result as HttpWebResponse;

            using(var sr = new StreamReader(result.GetResponseStream())) {
                sr.ReadToEnd();
            }
        }
    }
}