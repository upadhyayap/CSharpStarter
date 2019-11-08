using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpStarter.src.main.Threads
{
    public class TaskDemo
    {
        public void DoWorkInSimpleTask() {
            Task task1 = new Task(() => Console.WriteLine($"Do work in simple task in thread id {Thread.CurrentThread.ManagedThreadId}"));
            Task task2 = task1.ContinueWith((tx) => Console.WriteLine($"task t1 continued into t2 in thread id {Thread.CurrentThread.ManagedThreadId}"));
            task1.Start();
            // Another way of running a thread
            Task task3 = Task.Run(() => Console.WriteLine("This one is using Task.Run"));
            // task1.Wait();
            // task2.Wait();
            // This One line is same as above
            Task.WaitAll(task1, task2, task3);

            TaskFactory taskFactory = new TaskFactory();
            taskFactory.StartNew(() => Console.WriteLine("task created from task factory"));
        }
    }
}