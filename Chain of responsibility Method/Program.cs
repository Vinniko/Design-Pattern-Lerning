using System;
using Chain_of_responsibility_Method.Handlers;
using Chain_of_responsibility_Method.Models;

namespace Chain_of_responsibility_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler managingHandler = new ManagingHandler();
            AbstractHandler programmingHandler = new ProgrammingHandler();
            AbstractHandler testingHandler = new TestingHandler();
            managingHandler.Successor = programmingHandler;
            programmingHandler.Successor = testingHandler;
            Task task = new Task("Managing");
            managingHandler.HandleRequest(task);
            task.TaskName = "Programming";
            managingHandler.HandleRequest(task);
            task.TaskName = "Testing";
            managingHandler.HandleRequest(task);
        }
    }
}