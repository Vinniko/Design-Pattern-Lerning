namespace Iterator_Method.Interfaces
{
    public interface IEnumerable
    {
        IEnumerator CreateEnumerator();
        int Count { get;}
        IModel this[int index] { get; }
    }
}
