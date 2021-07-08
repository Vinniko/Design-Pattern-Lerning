using Template_Method.Interfaces;

namespace Template_Method.Services
{
    public sealed class FileService : BaseService
    {
        public FileService(string path, IReader reader, IParser parser) : base(path)
        {
            _reader = reader;
            _parser = parser;
        }
        public override string Read(string path)
        {
            return _reader.Read(path);
        }

        public override void Pars(string text)
        {
            _parser.Pars(text);   
        }

        private IReader _reader;
        private IParser _parser;
    }
}
