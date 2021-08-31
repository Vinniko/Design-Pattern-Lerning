using System.Linq;
using Interpreter_Method.Interfaces;
using Interpreter_Method.Models;

namespace Interpreter_Method.Services
{
    public class FirstLetterToUpperExpression : IExpression
    {
        #region Constructors

        public FirstLetterToUpperExpression(IExpression wordExpression)
        {
            _wordExpression = wordExpression;
        }

        #endregion



        #region Main Logic

        public void Interpret(IContext context)
        {
            string value = (context as Context).getValueByName((_wordExpression as WordExpression).getName());
            (context as Context).setValue((_wordExpression as WordExpression).getName(),
                value.First().ToString().ToUpper() + value.Substring(1));
        }

        #endregion



        #region Fields

        private IExpression _wordExpression;

        #endregion
    }
}