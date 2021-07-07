namespace Command_Method.Interfaces
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
