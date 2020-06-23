using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Prototype_Method.Interfaces;

namespace Prototype_Method.Models
{
    [Serializable]
    class Character : ICharacter, IClonable
    {
        #region Constructors

        public Character(string name, int age)
        {
            Name = name;
            Age = age;
        }

        #endregion



        #region Main Logic

        public void Move()
        {
            Console.WriteLine("Идёт " + Name);
        }

        public void Hit()
        {
            Console.WriteLine("Бьет, как возраста ему, раз " + Age);
        }

        public IClonable Clone()
        {
            return this.MemberwiseClone() as IClonable;
        }

        public object DeepCopy()
        {
            object character = null;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                var binFormatter = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));
                binFormatter.Serialize(memoryStream, this);
                memoryStream.Seek(0, SeekOrigin.Begin);
                character = binFormatter.Deserialize(memoryStream);
            }
            return character;
        }


        #endregion



        #region Fields

        public string Name { get; set; }

        public int Age { get; set; }

        #endregion
    }
}
