using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Developers_Pattern_Lerning.Model;

namespace Developers_Pattern_Lerning.Creater
{
    public abstract class CookieFactory
    {
        #region Constructor

        public CookieFactory(string title)
        {
            Title = title;
        }

        #endregion



        #region Main Logic

        public abstract Cookie Create(string title);

        #endregion



        #region Fields

        /// <summary>
        /// Factory titile
        /// </summary>
        public string Title = string.Empty;

        #endregion
    }
}
