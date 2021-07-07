using Command_Method.Interfaces;
using Command_Method.Models;
using Command_Method.Services;
using Command_Method.Commands;

namespace Command_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            IReceiver consoleWriter = new ConsoleWriter();
            ICommand buttonOnClick = new ButtonOnClickCommand(consoleWriter);
            IInvoker button = new Button();
            button.SetCommand(buttonOnClick);
            button.Run();
            button.Cancel();
        }
    }
}
