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

    }


    class ProductCompararer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}