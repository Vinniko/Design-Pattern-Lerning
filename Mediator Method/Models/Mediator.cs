using Mediator_Method.Interfaces;

namespace Mediator_Method.Models
{
    public class Mediator : IMediator
    {
        #region Main Logic

        public void Send(string message, AbstractMediableModel model)
        {
            if (model == Musician)
            {
                Guitar.Realize(message);
            }
            else
            {
                Musician.Realize(message);
            }
        }

        #endregion



        #region Fields

        public AbstractMediableModel Musician { get; set; }
        public AbstractMediableModel Guitar { get; set; }

        #endregion
    }
}