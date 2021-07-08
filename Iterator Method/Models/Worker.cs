using System;
using System.Collections.Generic;
using System.Text;
using Iterator_Method.Interfaces;

namespace Iterator_Method.Models
{
    public sealed class Worker : IModel
    {
        public Worker(string name)
        {
            Name = name;
        }
        public string Name { get; set;}
    }
}
