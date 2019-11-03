using System;
namespace CSharpStarter.src.main.Delegate
{

    public delegate void Printer(string x);
    public class DelDemo
    {
        public void ConsolePrinter(string x) {
            Console.WriteLine(x);
        }

        public void print(Printer pr){
            pr.Invoke("Executed delegate");
        }

    }
}