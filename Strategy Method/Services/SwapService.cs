using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Method.Services
{
    class SwapService
    {
        public void Swap(List<int> collection, int index, int min)
        {
            int tmp = collection[index];
            collection[index] = collection[min];
            collection[min] = tmp;
        }
    }
}
