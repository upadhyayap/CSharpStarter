using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpStarter.src.main.Threads
{
    public class TaskDemo
    {
        public Task DoWorkInSimpleTask() {
            Task task = new Task(() => Console.WriteLine($"Do work in simple task in thread id {Thread.CurrentThread.ManagedThreadId}"));
            task.Start();

            return task;
        }
    }
}