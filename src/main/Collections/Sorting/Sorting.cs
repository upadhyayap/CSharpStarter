using System.Linq;
using System;
using System.Collections.Generic;
using CSharpStarter.src.main.Misc;

namespace CSharpStarter.src.main.Collections.Sorting
{
    public class ProductSorting 
    {
        public void sort() {
            List<Product> products = Product.GetSampleProducts();
            products.Sort(new ProductCompararer());

            foreach (Product item in products)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void sortWithDelegate() {
            List<Product> products = Product.GetSampleProducts();
            products.Sort(delegate (Product x, Product y){
                return x.Name.CompareTo(y.Name);
            });

            foreach (Product item in products)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void SortByLambda(){
            List<Product> products = Product.GetSampleProducts();

            products.Sort((x,y) => x.Name.CompareTo(y.Name));

            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
            }
        }

          public void PrintWithoutSort(){
            List<Product> products = Product.GetSampleProducts();

            foreach (var item in products.OrderBy((x => x.Name)))
            {
                Console.WriteLine(item.Name);
            }
        }

        public void filter(){
            List<Product> products = Product.GetSampleProducts();

            // Predicate<Product> test = delegate (Product p) {return p.Price > 10;};
            // List<Product> matches = products.FindAll(test);

            // Action<Product> print = delegate (Product p) {Console.WriteLine(p.Name);};
            // matches.ForEach(print);

            products
            .FindAll((p) => p.Price > 10)
            .ForEach((x) => Console.WriteLine(x.Name));

            // products
            // .Where((p) => p.Price > 10)
            // .All((x) => Console.WriteLine(x.Name))

            
        }

    }


    class ProductCompararer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}