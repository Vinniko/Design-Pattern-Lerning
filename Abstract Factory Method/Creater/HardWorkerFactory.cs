﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory_Method.Models;

namespace Abstract_Factory_Method.Creater
{
    class HardWorkerFactory : RobotFactory
    {
        public override SupportModel SupportModelCreate()
        {
            return new LegModel();
        }
        public override WeaponModel WeaponModelCreate()
        {
            return new HandModel();
        }
    }
}
