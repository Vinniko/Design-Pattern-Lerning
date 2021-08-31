using System.Collections.Generic;
using Interpreter_Method.Interfaces;

namespace Interpreter_Method.Models
{
    public class Context : IContext
    {
        #region Contructors

        public Context(Dictionary<string, string> args)
        {
            _params_names = args;
        }

        #endregion


        
        #region Main Logic

        public string getValueByName(string name)
        {
            if (_params_names.ContainsKey(name))
            {
                return _params_names[name];
            }

            return null;
        }

        public void setValue(string name, string value)
        {
            if (_params_names.ContainsKey(name))
            {
                _params_names[name] = value;
            }
            else
            {
                _params_names.Add(name, value);
            }
        }

        #endregion
        
        
        
        #region Fields

        private readonly Dictionary<string, string> _params_names;

        #endregion
    }
}