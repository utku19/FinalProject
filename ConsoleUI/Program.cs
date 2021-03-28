using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("----");

            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
