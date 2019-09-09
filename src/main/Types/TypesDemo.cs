using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpStarter.src.main.Types
{
    public class TypesDemo
    {
        public void Typetest()
        {
            var book = new { title = "c# in depth", author= "Anand"};

            Console.WriteLine(book.title);
        }
    }
}
