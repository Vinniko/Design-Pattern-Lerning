using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Method.Services
{
    class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private Singleton()
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
