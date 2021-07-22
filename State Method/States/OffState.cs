using System;
using State_Method.Interfaces;
using State_Method.Models;

namespace State_Method.States
{
    public sealed class OffState : IState
    {
        public void Handle(IModel model)
        {
            Console.WriteLine("Computer is turned on");
            (model as Computer).State = new OnState();
        }
    }
}
