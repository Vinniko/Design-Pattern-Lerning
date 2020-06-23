using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype_Method.Models;
using Prototype_Method.Interfaces;

namespace Prototype_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character("Боец", 20);
            var clone = character.DeepCopy() as Character;
            character.Move();
            character.Hit();
            clone.Move();
            clone.Hit();
            clone.Name = "Боец 0.2";
            character.Move();
            clone.Move();
            Console.ReadKey();
        }
    }
}
