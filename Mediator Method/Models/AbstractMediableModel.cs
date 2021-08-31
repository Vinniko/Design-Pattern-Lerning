using Mediator_Method.Interfaces;

namespace Mediator_Method.Models
{
    public abstract class AbstractMediableModel : IModel
    {
        #region Constructors

        public AbstractMediableModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        #endregion



        #region Main Logic

        public virtual void Send(string message)
        {
            _mediator.Send(message, this);

        }

        public abstract void Realize(string message);

        #endregion



        #region Fields

        private IMediator _mediator;

        #endregion
    }
}