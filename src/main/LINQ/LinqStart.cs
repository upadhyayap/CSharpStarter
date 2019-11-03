
using System;
using CSharpStarter.src.main.Misc;
using System.Collections.Generic;
using System.Linq;

namespace CSharpStarter.src.main.LINQ
{
    public class LinqStart
    {
        public void filter (){
            List<Product> products = Product.GetSampleProducts();
            
            var filtered = from Product p in products where p.Price > 10 select p;

            foreach (var item in filtered)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void filterWithJoin(){
            List<Product> products = Product.GetSampleProducts();
            List<Supplier> suppliers = Supplier.getSampleSuppliers();

            var filtered = from p in products
                        join s in suppliers
                        on p.SupplierId equals s.id
                        where p.Price > 10
                        orderby p.Name, s.Name
                        select new {SupplierName = s.name, ProductName = p.Name};
            foreach (var item in filtered)
            {
                Console.WriteLine($"Supplier for {item.ProductName} is {item.SupplierName}");
            }
        }
    }

    public class Supplier {
        public string name;
        public int id;

        public string Name {get;set;}
        public int Id {get;set;}
        public  Supplier(string SupName, int SupId) {
            name = SupName;
            id  = SupId;
        }

        Supplier() {}

        public static List<Supplier> getSampleSuppliers(){
            return new List<Supplier> {
                new Supplier {name = "Apple", id = 1},
                new Supplier {name = "Samsung", id = 2},

            };
        }
        
    }
}