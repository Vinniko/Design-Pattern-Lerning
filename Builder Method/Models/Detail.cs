using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method.Models
{
    class Detail
    {
        public Detail(string title)
        {
            Title = title;
        }
        public string Title { get; set; }
    }
}
