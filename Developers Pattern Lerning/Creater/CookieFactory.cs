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

        /// <summary>
        /// Create some cookies with title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
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
