namespace Command_Method.Interfaces
{
    public interface IInvoker
    {
        void SetCommand(ICommand command);
        void Run();
        void Cancel();
    }
}
