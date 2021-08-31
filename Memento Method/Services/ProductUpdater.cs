using System;
using Memento_Method.Models;

namespace Memento_Method.Services
{
    public class ProductUpdater 
    {
        public Product Update(Product product, string title = null, int qty = -1, decimal price = -1)
        {
            if (title != null)
            {
                product.Title = title;
            }

            if (!qty.Equals(-1))
            {
                product.Qty = qty;
            }

            if (!price.Equals(-1))
            {
                product.Price = price;
            }

            return product;
        }
    }
}