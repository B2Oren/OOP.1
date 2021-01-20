using System;

namespace OOP._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CatgoryId = 2;
            product1.ProductName = "masa";
            product1.UnıtInStock = 3;
            product1.UnitPrice = 500;

            Product product2 = new Product {Id = 2,CatgoryId=5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine();


        }
    }
}
