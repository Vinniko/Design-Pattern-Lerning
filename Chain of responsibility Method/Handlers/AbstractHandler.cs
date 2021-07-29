using Chain_of_responsibility_Method.Interfaces;
using Chain_of_responsibility_Method.Models;

namespace Chain_of_responsibility_Method.Handlers
{
    public abstract class AbstractHandler : IHandler
    {
        public abstract void HandleRequest(Task task);
        public IHandler Successor { get; set; }

    }
}