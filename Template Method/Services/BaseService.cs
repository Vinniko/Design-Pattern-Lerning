using Template_Method.Interfaces;

namespace Template_Method.Services
{
    public abstract class BaseService : IService, IReader, IParser
    {
        public BaseService(string path)
        {
            _path = path;
        }
        public void Run()
        {
            Pars(Read(_path));
        }

        public abstract string Read(string path);
        public abstract void Pars(string text);

        private string _path;
    }
}
