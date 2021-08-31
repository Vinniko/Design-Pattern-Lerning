using Memento_Method.Interfaces;

namespace Memento_Method.Models
{
    public class ProductMemento : IModel
    {
        public string Title { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
    }
}