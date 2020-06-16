using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Singleton_Method.Services;

namespace Singleton_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.GetInstance();
            singleton.TextWrite();
        }
    }
}
