using LINQConsoleCoreApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQConsoleCoreApp { class Program
    { 
        #region
        SeedData List<Product> productList = new List<Product>(); 
        public void SeedData()
        { productList = new List<Product>() 
        {
            new Product() { ProductId="P001",ProductName="Laptop",Brand ="Dell",Quantity = 5,Price = 35000 }, 
            new Product() { ProductId = "P002", ProductName = "Camera", Brand = "Canon", Quantity = 8, Price = 28500 },
            new Product() { ProductId = "P003", ProductName = "Tablet", Brand = "Lenevo", Quantity = 4, Price = 15000 },
            new Product() { ProductId = "P004", ProductName = "Mobile", Brand = "Apple", Quantity = 9, Price = 65000 }, 
            new Product() { ProductId = "P005", ProductName = "Earphones", Brand = "Boat", Quantity = 2, Price = 1500 } 
        }; 
        }
        #endregion
        static void Main(string[] args) {
            Program program = new Program(); 
            program.SeedData(); 
            #region Query1 
                Console.WriteLine("Query1");
            var productName = from product in program.productList 
                              where product.Price > 20000 && product.Price < 40000 select product.ProductName;
            foreach(var pn in productName) { Console.WriteLine(pn);}
            #endregion
            #region
            Query2 Console.WriteLine("\nQuery2");
            var containsA = from product in program.productList
                            where product.ProductName.Contains("a") 
                            select new { product.ProductId, product.ProductName, product.Brand, product.Quantity, product.Price }; 
            containsA.ToList().ForEach(s=>Console.WriteLine($"Product id::{s.ProductId}\tProduct Name::{s.ProductName}" + $"\tBrand::{s.Brand}\tQuantity::{s.Quantity}\tPrice::{s.Price}")); 
            #endregion
            #region 
            Query3 Console.WriteLine("\nQuery3"); var orderByProductName = from product in program.productList 
                                                                           orderby product.ProductName select product; 
            foreach(var s in orderByProductName) { Console.WriteLine($"Product id::{s.ProductId}\tProduct Name::{s.ProductName}" + $"\tBrand::{s.Brand}\tQuantity::{s.Quantity}\tPrice::{s.Price}"); } #endregion #region
            Query4 
                Console.WriteLine("\nQuery4");
            var highestPrice =program.productList.Max(maxPrice=>maxPrice.Price );
            Console.WriteLine($"Highest Price:{highestPrice}"); #endregion #region Query5 Console.WriteLine("\nQuery5");
 bool checkProductWithProductID = program.productList.Any(products => products.ProductId == "P003"); 
            Console.WriteLine(checkProductWithProductID);
            #endregion } } }