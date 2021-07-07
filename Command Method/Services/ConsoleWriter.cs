using System;
using System.Collections.Generic;
using System.Text;
using Command_Method.Interfaces;

namespace Command_Method.Services
{
    public sealed class ConsoleWriter : IWriter, IReceiver
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
        public void Operation()
        {
            if (!_status)
            {
                _status = true;
                Write("Система включена");
            }
            else
            {
                _status = false;
                Write("Система выключена");
            }
        }

        private bool _status = false;
    }
}
