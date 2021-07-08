using Iterator_Method.Interfaces;

namespace Iterator_Method.Services
{
    public sealed class CompanyEnumerator : IEnumerator
    {
        public CompanyEnumerator(IEnumerable enumerable)
        {
            _aggregate = enumerable;
        }
        public IModel CurrentItem()
        {
            return _aggregate[_index];
        }

        public IModel First()
        {
            return _aggregate[0];
        }
        public bool IsDone()
        {
            return _index == _aggregate.Count;
        }

        public IModel Next()
        {
            return _aggregate[_index++];
        }

        private int _index = 0;

        private IEnumerable _aggregate;
    }
}
