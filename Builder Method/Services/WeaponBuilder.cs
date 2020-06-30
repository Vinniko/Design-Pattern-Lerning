using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_Method.Models;

namespace Builder_Method.Services
{
    abstract class WeaponBuilder
    {
        public Weapon _weapon { get; private set; }
        public void CreateWeapon()
        {
            _weapon = new Weapon();
        }
        public abstract void SetBlade();
        public abstract void SetGuard();
        public abstract void SetDetail();
    }
}
