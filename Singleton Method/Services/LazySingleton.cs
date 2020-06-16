using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Method.Services
{
    class LazySingleton
    {
        private LazySingleton()
        {

        }
        public void TextWrite()
        {
            Console.WriteLine("Lazy Singleton работает");
        }
        
        public static LazySingleton GetInstance()
        {
            return Nested.instance;
        }
        private class Nested
        {
            static Nested() { }
            public static readonly LazySingleton instance = new LazySingleton();
        }
    }
}
