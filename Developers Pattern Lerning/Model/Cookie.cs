using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Pattern_Lerning.Model
{
    public abstract class Cookie
    {
        #region Constructors

        public Cookie(string title)
        {
            Title = title;
        }

        #endregion



        #region Fields

        /// <summary>
        /// Cookie title
        /// </summary>
        public string Title = String.Empty;

        #endregion

    }
}
