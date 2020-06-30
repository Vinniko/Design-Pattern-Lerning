using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Method.Services
{
    class SelectSort : ISort
    {
        public SelectSort(SwapService swapService)
        {
            _swapService = swapService;
        }
        public List<int> Sort(List<int> collection)
        {
            int left = 0;
            int right = collection.Count;
            var tmpCollection = collection;
            for (var i = left; i < right; i++)
            {
                int min = i;
                for(var j = i + 1; j <= right; j++)
                {
                    if (tmpCollection[min] > tmpCollection[j])
                        min = j;
                }
                _swapService.Swap(tmpCollection, i, min);
            }
            return tmpCollection;
        }

        private SwapService _swapService;
    }
}
