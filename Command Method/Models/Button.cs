using Command_Method.Interfaces;

namespace Command_Method.Models
{
    public sealed class Button : IModel, IInvoker
    {
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Run()
        {
            if(_command != null)
                _command.Execute();
        }

        public void Cancel()
        {
            _command.Undo();
        }

        private ICommand _command;
    }
}
