using System;
using Mediator_Method.Models;

namespace Mediator_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            AbstractMediableModel guitar = new Guitar(mediator);
            AbstractMediableModel musician = new Musician(mediator);
            mediator.Musician = musician;
            mediator.Guitar = guitar;
            
            musician.Send("ДО");
            guitar.Send("ДО");
            musician.Send("РЕ");
            guitar.Send("МИ");
        }
    }
}