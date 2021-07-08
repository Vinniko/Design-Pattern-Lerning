using System;
using Template_Method.Interfaces;

namespace Template_Method.Services
{
    public sealed class TxtFileParser : IParser
    {
        public void Pars(string text)
        {
            Console.WriteLine("Pars some text from .txt file");
        }
    }
}
