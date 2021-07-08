using Iterator_Method.Interfaces;
using Iterator_Method.Services;

namespace Iterator_Method.Models
{
    public sealed class Company : IModel, IEnumerable
    {
        public Company(string title)
        {
            Title = title;
            _workers = new Worker[] { new Worker("Ben"), new Worker("Jina"), new Worker("Len") };
        }

        public IEnumerator CreateEnumerator()
        {
            return new CompanyEnumerator(this);
        }
        public int Count 
        { 
            get 
            {
                return _workers.Length;
            } 
        }
        public IModel this[int index]
        {
            get
            {
                return _workers[index];
            }
        }

        public string Title { get; set; }
        private Worker[] _workers;
    }
}
