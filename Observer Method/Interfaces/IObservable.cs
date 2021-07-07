namespace Observer_Method.Interfaces
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void NotifyObservers(IModel model);
        void RemoveObserver(IObserver observer);
    }
}
