using System;
using Chain_of_responsibility_Method.Models;

namespace Chain_of_responsibility_Method.Handlers
{
    public class TestingHandler : AbstractHandler
    {
        #region Main Logic

        public override void HandleRequest(Task task)
        {
            if (task.TaskName == HANDLER_TASK_NAME)
            {
                Console.WriteLine("Tester working with this task");
            }
            else if(Successor != null)
            {
                Console.WriteLine("Tester set this tusk another worker");
                Successor.HandleRequest(task);
            }
        }

        #endregion



        #region Fields

        public const string HANDLER_TASK_NAME = "Testing";

        #endregion
    }
}