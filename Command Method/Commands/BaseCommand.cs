using Command_Method.Interfaces;

namespace Command_Method.Commands
{
    public class BaseCommand : ICommand
    {
        public BaseCommand(IReceiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.Operation();
        }
        public void Undo()
        {
            _receiver.Operation();
        }

        private IReceiver _receiver;
    }
}
