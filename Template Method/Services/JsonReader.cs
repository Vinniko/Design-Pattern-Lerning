using System;
using Template_Method.Interfaces;

namespace Template_Method.Services
{
    public sealed class JsonReader : IReader
    {
        public string Read(string path)
        {
            Console.WriteLine("Reading some JSON from url.");
            return "text";
        }
    }
}
