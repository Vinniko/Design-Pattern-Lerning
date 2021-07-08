using System;
using Template_Method.Interfaces;

namespace Template_Method.Services
{
    public sealed class JsonParser : IParser
    {
        public void Pars(string text)
        {
            Console.WriteLine("Pars some JSON from url.");
        }
    }
}
