using Mediator_Method.Models;

namespace Mediator_Method.Interfaces
{
    public interface IMediator
    {
        void Send(string message, AbstractMediableModel model);
    }
}