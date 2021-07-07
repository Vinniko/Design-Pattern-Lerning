using System;
using System.Collections.Generic;
using System.Text;
using Observer_Method.Interfaces;

namespace Observer_Method.Services
{
    public sealed class ConsoleWriter : IWriter, IObserver
    {
        public void Write(IModel model)
        {
            Console.WriteLine($"Выведено на консоль: {model}");
        }

        public void Update(IModel model)
        {
            Write(model);
        }
    }
}
