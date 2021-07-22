using System;
using State_Method.Interfaces;
using State_Method.Models;

namespace State_Method.States
{
    public sealed class OnState : IState
    {
        public void Handle(IModel model)
        {
            Console.WriteLine("Computer is turned off");
            (model as Computer).State = new OffState();
        }
    }
}
