using System.Collections.Generic;
using Memento_Method.Interfaces;

namespace Memento_Method.Models
{
    public abstract class AbstractMementableModel : IModel
    {
        #region Main Logic

        public abstract IModel SaveState();

        public abstract void RestoreState(IModel model);

        #endregion



        #region Fields

        protected IModel _memento;

        #endregion
    }
}