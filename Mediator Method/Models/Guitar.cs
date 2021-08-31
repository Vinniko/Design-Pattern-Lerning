using System;
using Mediator_Method.Interfaces;

namespace Mediator_Method.Models
{
    public class Guitar : AbstractMediableModel
    {
        #region Constructors

        public Guitar(IMediator mediator) 
            : base(mediator)
        { }

        #endregion



        #region Main Logic

        public override void Realize(string message)
        {
            Console.WriteLine($"Гитара играет ноту {message}");
        }

        #endregion
    }
}