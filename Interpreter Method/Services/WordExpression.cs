using Interpreter_Method.Interfaces;

namespace Interpreter_Method.Services
{
    public class WordExpression : IExpression
    {
        #region Constructors

        public WordExpression(string name)
        {
            _name = name;
        }

        #endregion



        #region Main Logic

        public void Interpret(IContext context)
        {
            
        }

        #endregion



        #region Get/Set

        public string getName()
        {
            return _name;
        }

        #endregion



        #region Fields

        private string _name;

        #endregion
    }
}