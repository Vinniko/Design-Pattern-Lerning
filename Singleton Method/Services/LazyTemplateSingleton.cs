using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Method.Services
{
    class LazyTemplateSingleton
    {
        private static readonly Lazy<LazyTemplateSingleton> instance = new Lazy<LazyTemplateSingleton>(() => new LazyTemplateSingleton());

        private LazyTemplateSingleton() { }

        public static LazyTemplateSingleton GetInstance()
        {
            return instance.Value;
        }

        public void TextWrite()
        {
            Console.WriteLine("Lazy Template Singleton работает");
        }
    }
}
