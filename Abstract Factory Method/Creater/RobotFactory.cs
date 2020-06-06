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
        /// <summary>
        /// Create support for robot
        /// </summary>
        /// <returns></returns>
        public abstract SupportModel SupportModelCreate();
        /// <summary>
        /// Create weapon for robot
        /// </summary>
        /// <returns></returns>
        public abstract WeaponModel WeaponModelCreate();
    }
}
