using State_Method.Interfaces;

namespace State_Method.Models
{
    public sealed class Computer : IModel
    {
        #region Constructors

        public Computer(IState state)
        {
            State = state;
        }

        #endregion



        #region MainLogic

        public void PressButton()
        {
            State.Handle(this);
        }

        #endregion



        #region Fields

        public IState State { get; set; }

        #endregion
    }
}
