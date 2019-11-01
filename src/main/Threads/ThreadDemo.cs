using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System;

namespace CSharpStarter.src.main.Threads
{
    public class ThreadDemo
    {
        public void LegacyWay(){
            Thread t1 = new Thread(new ThreadStart(new MyThread().Run));
            t1.Start();
            // t1.Join();
            Console.WriteLine("out of calling method");
        }

        public async void AsyncWay() {
            MyThread myThread = new MyThread();
            MyThread.TaskDemo();
        }
    }

    public class MyThread {
        public void Run() {
            Thread.CurrentThread.Name = "My Thread";
            Console.WriteLine(Thread.CurrentThread.Name);
            
            IEnumerable<int> en = Enumerable.Range(1,20);
            // foreach (var item in en){
            //     Console.WriteLine(item);
            // }
            Thread.Sleep(10);
            Console.WriteLine($"out of {Thread.CurrentThread.Name}");
        }

       public static void TaskDemo()  {  
            Task task = new Task(CallMethod);  
            task.Start();  
            task.Wait();  
            Console.ReadLine();  
      }  
  
        static async void CallMethod()  {  
            string filePath = "D:\\ThreadDemo.txt";  
            Task<int> task = ReadFile(filePath);  
    
            Console.WriteLine(" Other Work 1");  
            Console.WriteLine(" Other Work 2");  
            Console.WriteLine(" Other Work 3");  
    
            int length = await task;  
            Console.WriteLine(" Total length: " + length);  
    
            Console.WriteLine(" After work 1");  
            Console.WriteLine(" After work 2");  
        }  
  
        static async Task<int> ReadFile(string file)  {  
            int length = 0;  
    
            Console.WriteLine(" File reading is stating");  
            using (StreamReader reader = new StreamReader(file))  
            {  
                // Reads all characters from the current position to the end of the stream asynchronously    
                // and returns them as one string.    
                string s = await reader.ReadToEndAsync();  
    
                length = s.Length;  
            }  
            Console.WriteLine(" File reading is completed");  
            return length;  
        }  
    }
}