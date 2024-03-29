using System.Threading;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

namespace CSharpStarter.src.main.Misc
{
    class OldProps {
        private string name;
        
        public string Name {
            get { 
                return name;
            }
            set {
                name = value;
            }
        }
    }

    class NewProps {
        // private string name;
        public string Name {get; private set;}
    }

    class AutoImplementedProps {
        public static void ListProducts() {
            foreach (var item in Product.GetSampleProducts())
            {
                Console.WriteLine($" Price of {item.Name} is {item.Price}");
            }
        }
    }

    class Product {
        
        // public readonly string name
        public string Name {get;set;}
        public decimal? Price{get;set;}

        public int supplierId;
        public int SupplierId{get;set;}

        public Product(string name, decimal? Price = null, int supId = -1) {
            this.Name = name;
            this.Price = Price;
            this.supplierId = supId;
        }

         public Product () {}

        public static List<Product> GetSampleProducts(){
            return new List<Product> {
                new Product {Name = "Computer", Price = 100, SupplierId = 1},
                new Product {Name = "Mouse", Price = 10, SupplierId = 2}
            };
        }

    }
    
    

}