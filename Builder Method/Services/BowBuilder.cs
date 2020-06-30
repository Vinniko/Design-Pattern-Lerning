using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_Method.Models;

namespace Builder_Method.Services
{
    class BowBuilder : WeaponBuilder
    {
        public override void SetBlade()
        {
            //
        }

        public override void SetGuard()
        {
            //
        }

        public override void SetDetail()
        {
            this._weapon.detail = new Detail("Деревянная основа из березы");
        }
    }
}
