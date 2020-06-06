using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Developers_Pattern_Lerning.Model;
using Developers_Pattern_Lerning.Creater;

namespace Developers_Pattern_Lerning
{
    class Program
    {
        static void Main(string[] args)
        {
            CookieFactory cookieFactory = new TwixCookieFactoryCreater("ООО Twix Right Stick");
            Console.WriteLine(cookieFactory.Title + " starting work.");
            Cookie cookie = cookieFactory.Create("Chocolate Twix");
            Console.WriteLine("Factory cooking " + cookie.Title);
            Console.ReadKey();
        }
    }
}
