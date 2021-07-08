namespace Iterator_Method.Interfaces
{
    public interface IEnumerator
    {
        IModel CurrentItem();
        IModel First();
        bool IsDone();
        IModel Next();
    }
}
