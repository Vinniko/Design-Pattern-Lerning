using System.Collections.Generic;
using Memento_Method.Interfaces;

namespace Memento_Method.Models
{
    public class ProductHistory
    {
        #region Constructors

        public ProductHistory()
        {
            MementoProducts = new Stack<IModel>();
        }

        #endregion



        #region Fields

        public Stack<IModel> MementoProducts { get; private set; }

        #endregion
        
    }
}