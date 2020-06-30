using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method.Models
{
    class Weapon
    {
        public Blade blade { get; set; }

        public Guard guard { get; set; }

        public Detail detail { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (blade != null)
                stringBuilder.Append("Материал лезвия: " + blade.Material + "\n");
            if (guard!= null)
                stringBuilder.Append("Гарда/ защитный механизм: " + guard.Type + "\n");
            if (detail != null)
                stringBuilder.Append("Так же есть такая деталь как: " + detail.Title + "\n");

            return stringBuilder.ToString();
        }
    }
}
