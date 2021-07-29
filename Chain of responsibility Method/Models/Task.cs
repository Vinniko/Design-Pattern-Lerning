using Chain_of_responsibility_Method.Interfaces;

namespace Chain_of_responsibility_Method.Models
{
    public class Task : IModel
    {
        #region Constructors

        public Task(string taskName)
        {
            TaskName = taskName;
        }

        #endregion



        #region Fields

        public string TaskName { get; set; }

        #endregion
    }
}