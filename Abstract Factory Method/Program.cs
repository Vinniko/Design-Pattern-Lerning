using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory_Method.Creater;
using Abstract_Factory_Method.Models;

namespace Abstract_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotModel hardWorkerRobot = new RobotModel(new HardWorkerFactory());
            RobotModel destructorRobot = new RobotModel(new DestructorFactory());
            RobotModel workerRobot = new RobotModel(new WorkerFactory());

            hardWorkerRobot.Run();
            destructorRobot.Work();
            workerRobot.Work();
            hardWorkerRobot.Work();
            destructorRobot.Run();
            workerRobot.Run();

            Console.ReadKey();

        }
    }
}
