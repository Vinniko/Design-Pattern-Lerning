using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Method.Models
{
    class LazerSwordModel : WeaponModel
    {
        public override void Hit()
        {
            Console.WriteLine("Робот переполнен силой и машет лазерным мечом");
        }
    }
}
