using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Method.Models
{
    class HandModel : WeaponModel
    {
        public override void Hit()
        {
            Console.WriteLine("Робот работает руками в поле");
        }
    }
}
