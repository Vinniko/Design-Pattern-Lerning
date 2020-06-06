using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Developers_Pattern_Lerning.Model;

namespace Developers_Pattern_Lerning.Creater
{
    class SnikersCookieFactory : CookieFactory
    {
        #region Constructors

        public SnikersCookieFactory(string title) : base(title) { }

        #endregion



        #region Main Logic

        public override Cookie Create(string title)
        {
            return new SnikersCookie(title);
        }

        #endregion

    }
}
