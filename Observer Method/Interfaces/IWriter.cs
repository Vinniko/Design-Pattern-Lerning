using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Method.Interfaces
{
    public interface IWriter
    {
        void Write(IModel model);
    }
}
