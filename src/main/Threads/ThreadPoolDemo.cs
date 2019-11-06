using System.Threading.Tasks;
using System.Threading;
using System;

namespace CSharpStarter.src.main.Threads
{
    public class ThreadPoolDemo
    {
        public ManualResetEvent ManualSignal {get; set;}
        public void DoWorkInPool(){
            Console.WriteLine($"Running in thread {Thread.CurrentThread.ManagedThreadId}");

            ThreadPool.QueueUserWorkItem(new WaitCallback(DoWork));
        }
        public void DoWork(Object state) {
            Console.WriteLine($"Running in thread {Thread.CurrentThread.ManagedThreadId}");
            ManualSignal.Set();
        }
    }
}