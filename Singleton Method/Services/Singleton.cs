using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Method.Services
{
    class Singleton
    {
        public static readonly Singleton instance = new Singleton();
        public Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            return instance;
        }

        public void TextWrite()
        {
            Console.WriteLine("Singleton работает");
        }
    }
}
