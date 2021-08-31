using System;
using Memento_Method.Interfaces;

namespace Memento_Method.Models
{
    public class Product : AbstractMementableModel
    {
        #region Constructors

        public Product(string title, int qty, decimal price)
        {
            Title = title;
            Qty = qty;
            Price = price;
            _memento = new ProductMemento();
        }

        #endregion



        #region Main Logic

        public override IModel SaveState()
        {
            (_memento as ProductMemento).Title = Title;
            (_memento as ProductMemento).Qty = Qty;
            (_memento as ProductMemento).Price = Price;

            return _memento;
        }

        public override void RestoreState(IModel model)
        {
            Title = (_memento as ProductMemento).Title;
            Qty = (_memento as ProductMemento).Qty;
            Price = (_memento as ProductMemento).Price;
        }

        #endregion



        #region Staff

        public override string ToString()
        {
            return $"Продукт: {Title}\nКоличество: {Qty}\nЦена за шт.: {Price}";
        }

        #endregion
        
        

        #region Fields

        public string Title { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }

        #endregion
    }
}