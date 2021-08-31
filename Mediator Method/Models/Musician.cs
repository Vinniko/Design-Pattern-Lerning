using System;
using Mediator_Method.Interfaces;

namespace Mediator_Method.Models
{
    public class Musician : AbstractMediableModel
    {
        #region Constructors

        public Musician(IMediator mediator)
            : base(mediator)
        { }

        #endregion



        #region Main Logic

        public override void Realize(string message)
        {
            Console.WriteLine($"Музыкан слышит ноту: {message}");
        }

        #endregion
    }
}