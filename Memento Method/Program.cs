using System;
using Memento_Method.Models;
using Memento_Method.Services;

namespace Memento_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductUpdater productUpdater = new ProductUpdater();
            ProductHistory productHistory = new ProductHistory();
            Product product = new Product("Компьютер", 3, 48500);

            productUpdater.Update(product, default, -1, 50000);
            Console.WriteLine(product.ToString());
            productHistory.MementoProducts.Push(product.SaveState());
            productUpdater.Update(product, default, 0);
            Console.WriteLine(product.ToString());
            product.RestoreState(productHistory.MementoProducts.Pop());
            Console.WriteLine(product.ToString());
        }
    }
}