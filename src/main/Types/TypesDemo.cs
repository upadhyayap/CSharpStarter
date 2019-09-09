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
            var employee = (name : "Anand", designation: "SE");

            Console.WriteLine(book.title);
            Console.WriteLine(employee.name);
        }
    }
}
