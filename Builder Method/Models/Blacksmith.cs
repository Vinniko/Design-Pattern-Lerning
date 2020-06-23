using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_Method.Services;

namespace Builder_Method.Models
{
    class Blacksmith
    {
        public Weapon Forge(WeaponBuilder weaponBuilder)
        {
            weaponBuilder.CreateWeapon();
            weaponBuilder.SetBlade();
            weaponBuilder.SetGuard();
            weaponBuilder.SetDetail();
            return weaponBuilder.weapon;
        }
    }
}
