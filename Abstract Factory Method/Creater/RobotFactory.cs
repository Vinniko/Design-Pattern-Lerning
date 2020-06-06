using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory_Method.Models;

namespace Abstract_Factory_Method.Creater
{
    public abstract class RobotFactory
    {
        public abstract SupportModel SupportModelCreate();
        public abstract WeaponModel WeaponModelCreate();
    }
}
