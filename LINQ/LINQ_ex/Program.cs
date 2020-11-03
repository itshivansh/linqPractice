using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_ex
{

    class Program
    {
        static List<Product> ProductList = new List<Product>();
        static void SeedData()
        {
            ProductList.Add(new Product { ProductId = "P001", ProductName = "Laptop", Brand = "Dell", Quantity = 5, Price = 35000 });
            ProductList.Add(new Product { ProductId = "P002", ProductName = "Camera", Brand = "Canon", Quantity = 8, Price = 28500 });
            ProductList.Add(new Product { ProductId = "P003", ProductName = "Tablet", Brand = "Lenovo", Quantity = 4, Price = 15000 });
            ProductList.Add(new Product { ProductId = "P004", ProductName = "Mobile", Brand = "Apple", Quantity = 9, Price = 65000 });
            ProductList.Add(new Product{ProductId = "P005",ProductName="Earphones",Brand="Boat",Quantity=2,Price=1500});
            }
          static void Main(string[] args)
          {
            SeedData();
            //code to retrieve the Product names from Product List where Price is between 20000 to 40000.
            Console.WriteLine("\n1::");
            var filteredResult = from product in ProductList
                                 where product.Price > 20000 && product.Price < 40000
                                 select product.ProductName;
            foreach (var prdct in filteredResult)
            {
                Console.WriteLine($"Products in pricerange 20000to 40000:: { prdct}");
            }
            //code for retrieving the data from product List where ProductName contains letter 'a'
            Console.WriteLine("\n2::");
            var containing_a = from product in ProductList
                            where product.ProductName.Contains("a")
                            select (product.ProductId,product.ProductName,product.Price,product.Brand,product.Quantity);
            foreach (var prdct in containing_a)
            {
                Console.WriteLine($"product details which contain 'a':: { prdct}");
            }
            //code for retrieving all data from product List arranged in alphabetical order based on ProductName
            Console.WriteLine("\n3::");
            var alphabetical = from product in ProductList
                               orderby product.ProductName
                               select (product.ProductId, product.ProductName, product.Price, product.Brand, product.Quantity);
            foreach (var prdct in alphabetical)
            {
                Console.WriteLine($"product details alphabetically :: { prdct}");
            }
            //code for retrieving the highest Price from Product List
            Console.WriteLine("\n4::");
            var highestPrice = Program.ProductList.Max(price=>price.Price);
            Console.WriteLine($"Highest Price :: { highestPrice}");
            //code to check whether the Product with ProductId P003 exists in Product List or not.
            Console.WriteLine("\n5::");
            bool containing_P003 = ProductList.Any(products => products.ProductId == "P003");
            Console.WriteLine($"is containing 'P003':: {containing_P003}");
        }
    }
}
