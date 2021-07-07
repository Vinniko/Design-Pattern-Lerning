using System;
using System.Collections.Generic;
using System.Text;
using Command_Method.Interfaces;

namespace Command_Method.Commands
{
    public sealed class ButtonOnClickCommand : BaseCommand
    {
        public ButtonOnClickCommand(IReceiver receiver)
            : base(receiver) 
        { }
    }
}
