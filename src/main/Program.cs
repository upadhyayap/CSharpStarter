using System.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using CsharpStarter.src.main.Array;
using CsharpStarter.src.main.Types;
using CSharpStarter.src.main.Misc;
using CSharpStarter.src.main.Collections.Sorting;
using CSharpStarter.src.main.LINQ;
using CSharpStarter.src.main.Delegate;
using System.Collections.ObjectModel;
using CSharpStarter.src.main.Threads;
using CsharpStarter.src.main.Threads;
using System.Threading;

namespace CsharpStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread starting with Id {Thread.CurrentThread.ManagedThreadId}");
            // ArrayTest arrayTest = new ArrayTest();
            // arrayTest.printArray();

            // TypesDemo typesDemo = new TypesDemo();

            // typesDemo.Typetest();

            // OldProps old = new OldProps();
            // old.Name = "Anand";
            // Console.WriteLine(old.Name);

            // NewProps newProps = new NewProps();
            // newProps.Name = "Sardar";
            // Console.WriteLine(newProps.Name);

            // ArrayList names = new ArrayList();
            // names.Add("manish");
            // ExpBodiedMember expBodied = new ExpBodiedMember();
            // expBodied.Names = names;

            // Console.WriteLine(expBodied.Count);
            //  var name  = "Anand";
            // var desg = "microsoft";

            // Console.WriteLine("My name is " + name + " and i work for " + desg);

            // Console.WriteLine($"my name is {name}");

            // AutoImplementedProps.ListProducts();
            // Product product = new Product {Name = "comp", Price = 100}; // This call calls the default constructor for Product class and then calls setters for props
            // Product product = new Product(name: "comp", Price: 100);
            // Console.Write(product.Name);

            // ProductSorting productSorting = new ProductSorting();
            // productSorting.sort();
            // productSorting.sortWithDelegate();
            // productSorting.SortByLambda();
            // productSorting.PrintWithoutSort();
            // productSorting.filter();
            // LinqStart linqStart = new LinqStart();
            // linqStart.filter();
            // linqStart.filterWithJoin();

            // Delegate

            DelDemo delDemo = new DelDemo();
            // Printer pr = new Printer(delDemo.ConsolePrinter);
            // Printer pr1 = delegate(string x) {
            //     Console.WriteLine(x);
            // };

            //  delDemo.print(pr);
            // Implicit conversion from method group to delegate
            // delDemo.print(delDemo.ConsolePrinter);
            // passig delegate as lambda
            // delDemo.print((s) => Console.WriteLine("Delegate through lambda"));
            // passing Delegate as a anonymous method
            // delDemo.print(delegate(string x) {
            //     Console.WriteLine(x);
            // });
            
            // Program.DemostrateType<int>();

            // int ret;
            // int.TryParse("1", out ret);
            // Console.WriteLine(ret);
            
            List<int> List = new List<int>();

            // ThreadDemo threadDemo = new ThreadDemo();
            // threadDemo.LegacyWay();
            // threadDemo.AsyncWay();

            // BeginEnd beginEnd = new BeginEnd();
            // beginEnd.doWorkDelegateAsyncTest();

            // AsyncIO asyncIO = new AsyncIO("http://google.com");
            // asyncIO.AsyncDownload();

            // ThreadPoolDemo threadPoolDemo = new ThreadPoolDemo();
            // ManualResetEvent manualSignal = new ManualResetEvent(false);
            // threadPoolDemo.ManualSignal = manualSignal;
            // threadPoolDemo.DoWorkInPool();
            // manualSignal.WaitOne();

            // TaskDemo taskDemo = new TaskDemo();
            // taskDemo.DoWorkInSimpleTask();

            // AsyncIOWithTask asyncIOWithTask = new AsyncIOWithTask {Url = "http://google.com"};
            // asyncIOWithTask.Download();
            // asyncIOWithTask.DoInParallel();

            // AsyncAwait asyncAwaitLongOne = new AsyncAwait {Url = "https://go.microsoft.com/fwlink/p/?linkid=845299"};
            AsyncAwait asyncAwaitShortOne = new AsyncAwait {Url = "https://google.com"};
            Task<int> asyncResult =  asyncAwaitShortOne.download();
            asyncResult.Wait();

            Console.WriteLine($"Main Thread End with Id {Thread.CurrentThread.ManagedThreadId}");
        }

        static void DemostrateType<x>() {
            Console.WriteLine(typeof(List<>));
        }

      /*  static void CustomrIterator() {
            IEnumerable<int> iterable = CreateEnumerable();
            IEnumerator<int> iterator = iterable.GetEnumerator();
            Console.WriteLine("Starting to iterate");
            while (true) {
                Console.WriteLine("Calling MoveNext()...");
                bool result = iterator.MoveNext();
                Console.WriteLine("... MoveNext result={0}", result);
                if (!result) {
                    break;
                }
                Console.WriteLine("Fetching Current...");
                Console.WriteLine("... Current result={0}", iterator.Current);
            }
        }*/
    }
}
