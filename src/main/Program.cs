using System;
using System.Collections;
using System.Collections.Generic;
using CsharpStarter.src.main.Array;
using CsharpStarter.src.main.Types;
using CSharpStarter.src.main.Misc;
using CSharpStarter.src.main.Collections.Sorting;

namespace CsharpStarter
{
    class Program
    {
        static void Main(string[] args)
        {
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

            ProductSorting productSorting = new ProductSorting();
            productSorting.sort();
            productSorting.sortWithDelegate();

        }
    }
}
