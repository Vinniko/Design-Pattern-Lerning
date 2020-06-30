using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_Method.Services;

namespace Strategy_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<int> { 4, 5, 1, 3, 4, 8, 10 };
            var swap = new SwapService();
            ISort sort = new SelectSort(swap);
            var tmpArray = sort.Sort(array);
            for (var i = 0; i < tmpArray.Count; i++)
                Console.WriteLine(tmpArray[i]);

            sort = new InsertionSort(swap);
            tmpArray = sort.Sort(array);
            for (var i = 0; i < tmpArray.Count; i++)
                Console.WriteLine(tmpArray[i]);

            Console.ReadKey();

        }
    }
}
