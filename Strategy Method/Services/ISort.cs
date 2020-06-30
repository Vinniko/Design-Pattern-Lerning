using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Method.Services
{
    interface ISort
    {
        List<int> Sort(List<int> collection);
    }
}
