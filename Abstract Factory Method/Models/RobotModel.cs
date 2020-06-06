using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory_Method.Creater;

namespace Abstract_Factory_Method.Models
{
    public class RobotModel
    {
        #region Constructor

        public RobotModel(RobotFactory robotFactory)
        {
            Weapon = robotFactory.WeaponModelCreate();
            Support = robotFactory.SupportModelCreate();
        }


        #endregion



        #region MainLogic

        public void Run()
        {
            Support.Move();
        }

        public void Work()
        {
            Weapon.Hit();
        }

        #endregion



        #region Fields

        public WeaponModel Weapon { get; set; }
        public SupportModel Support { get; set; }

        #endregion
    }
}
