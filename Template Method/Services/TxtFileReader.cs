using System;
using Template_Method.Interfaces;

namespace Template_Method.Services
{
    public class TxtFileReader : IReader
    {
        public string Read(string path)
        {
            Console.WriteLine("Reading some .txt file.");
            return "text";
        }
    }
}
