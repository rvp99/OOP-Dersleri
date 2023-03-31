using System;
using System.Collections.Generic;
using System.Text;

namespace _00_Denemeler
{
    public class ProductManager
    {
        private List<Product> products;
        public ProductManager()
        {
            products = new List<Product>()
            {
                new Product(){Id = 1,Name = "Kalem"},
                new Product(){Id = 2,Name = "Silgi"},
                new Product(){Id = 3,Name = "Defter"}
            };

        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public void GetById(int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    Console.WriteLine(product.Name);
                }
                
            }
            Console.WriteLine("ID numarası yanlış.");

        }
    }
}
