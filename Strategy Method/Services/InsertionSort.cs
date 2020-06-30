using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Method.Services
{
    class InsertionSort : ISort
    {
        public InsertionSort(SwapService swapService)
        {
            _swapService = swapService;
        }
        public List<int> Sort(List<int> collection)
        {
            int left = 0;
            int right = collection.Count;
            var tmpColletion = collection;
            for (var i = left + 1; i <= right; i++)
                for (var j = i; j > left; j--)
                    if (tmpColletion[j - 1] > tmpColletion[j])
                        _swapService.Swap(tmpColletion, j - 1, j);
            return tmpColletion;
        }

        private SwapService _swapService;
    }
}
