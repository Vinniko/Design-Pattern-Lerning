using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_Method.Models;
using Builder_Method.Services;

namespace Builder_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var blacksmith = new Blacksmith();
            WeaponBuilder swordBuilder = new SwordBuilder();
            Weapon sword = blacksmith.Forge(swordBuilder);

            WeaponBuilder bowBuilder = new BowBuilder();
            Weapon bow = blacksmith.Forge(bowBuilder);

            Console.WriteLine(sword.ToString());
            Console.WriteLine(bow.ToString());
        }
    }
}
