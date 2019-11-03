using System;
using System.Net;
using System.IO;
using System.Threading;

namespace CsharpStarter.src.main.Threads
{
    public class AsyncIO
    {
        
        public AsyncIO(string url)
        {
            Url = url;
        }

        public string Url { get; set; }

        public void AsyncDownload()
        {
            Console.WriteLine($"Download Running in Thread id {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"started downloading content from {this.Url}");

            var httpRequest = HttpWebRequest.CreateHttp(this.Url);
            var httpResponse = httpRequest.GetResponse() as HttpWebResponse;

            var responseStream = httpResponse.GetResponseStream();
            String webContent;

            using(var sr = new StreamReader(responseStream)) {
                webContent = sr.ReadToEnd();
            }

            using(FileStream fileStream = new FileStream("/tmp/asyncio.txt", FileMode.OpenOrCreate))
            {
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(webContent);
            }

            Console.WriteLine($"Done Downloading in thread id {Thread.CurrentThread.ManagedThreadId}");
            
        }

        delegate void AsyncDownloadDelegate();
        public void AsyncDownloadThroughDelegate(){
            AsyncDownloadDelegate asyncDownloadDel = new AsyncDownloadDelegate(AsyncDownload);
            IAsyncResult asyncResult =  asyncDownloadDel.BeginInvoke(null, null);
            asyncDownloadDel.EndInvoke(asyncResult);
        }
    }
}
