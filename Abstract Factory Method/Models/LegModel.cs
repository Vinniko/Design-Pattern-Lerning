using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Method.Models
{
    class LegModel : SupportModel
    {
        public override void Move()
        {
            Console.WriteLine("Робот зашагал тяжёлыми ногами");
        }
    }
}
