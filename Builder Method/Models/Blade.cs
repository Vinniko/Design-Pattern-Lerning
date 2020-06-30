using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method.Models
{
    class Blade
    {
        public Blade(string material)
        {
            Material = material;
        }
        public string Material { get; set; }
    }
}
