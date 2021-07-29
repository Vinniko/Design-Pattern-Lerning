using System;
using Chain_of_responsibility_Method.Models;

namespace Chain_of_responsibility_Method.Handlers
{
    public class ManagingHandler : AbstractHandler
    {
        #region Main Logic

        public override void HandleRequest(Task task)
        {
            if (task.TaskName == HANDLER_TASK_NAME)
            {
                Console.WriteLine("Manager working with this task");
            }
            else if(Successor != null)
            {
                Console.WriteLine("Manager set this tusk another worker");
                Successor.HandleRequest(task);
            }
        }

        #endregion



        #region Fields

        public const string HANDLER_TASK_NAME = "Managing";

        #endregion
    }
}