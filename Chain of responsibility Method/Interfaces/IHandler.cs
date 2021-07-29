using Chain_of_responsibility_Method.Models;

namespace Chain_of_responsibility_Method.Interfaces
{
    public interface IHandler
    {
        void HandleRequest(Task task);
    }
}