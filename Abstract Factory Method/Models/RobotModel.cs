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

        public RobotModel(RobotFactory robotFactory, string title)
        {
            Weapon = robotFactory.WeaponModelCreate();
            Support = robotFactory.SupportModelCreate();
            Title = title;
        }


        #endregion



        #region MainLogic

        public void Run()
        {
            Console.Write(Title + ": ");
            Support.Move();
        }

        public void Work()
        {
            Console.Write(Title + ": ");
            Weapon.Hit();
        }

        #endregion



        #region Fields

        public WeaponModel Weapon { get; set; }
        public SupportModel Support { get; set; }

        public string Title { get; set; } = string.Empty;

        #endregion
    }
}
