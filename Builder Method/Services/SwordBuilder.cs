using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_Method.Models;

namespace Builder_Method.Services
{
    class SwordBuilder : WeaponBuilder
    {
        public override void SetBlade()
        {
            this._weapon.blade = new Blade("Нержавеющая сталь");
        }

        public override void SetGuard()
        {
            this._weapon.guard = new Guard("Квадратная гарда");
        }

        public override void SetDetail()
        {
            this._weapon.detail = new Detail("Деревянная рукоять");
        }
    }
}
