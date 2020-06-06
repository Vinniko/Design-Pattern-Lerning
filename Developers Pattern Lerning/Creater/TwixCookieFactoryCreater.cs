﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Developers_Pattern_Lerning.Model;

namespace Developers_Pattern_Lerning.Creater
{
    public class TwixCookieFactoryCreater : CookieFactory
    {
        #region Constructors

        public TwixCookieFactoryCreater(string title) : base(title)
        {

        }

        #endregion



        #region Main Logic

        public override Cookie Create(string title)
        {
            return new TwixCookie(title);
        }

        #endregion



        #region Fields

        

        #endregion
    }
}
