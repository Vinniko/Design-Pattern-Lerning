using State_Method.Models;
using State_Method.States;

namespace State_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(new OffState());

            for(var i = 0; i < 4; i++)
            {
                computer.PressButton();
            }
        }
    }
}
