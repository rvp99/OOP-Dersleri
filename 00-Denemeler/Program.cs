using System;
using System.Collections.Generic;
using System.Threading;

namespace _00_Denemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Id = 4, Name = "Kitap" };
            
            ProductManager productManager = new ProductManager();
            
            productManager.Add(product1);

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.Id);
            //}

            Console.WriteLine("***************");
            productManager.GetById(5);

          
            

        }
    }
}
