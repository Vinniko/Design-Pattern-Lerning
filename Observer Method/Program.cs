using Observer_Method.Interfaces;
using Observer_Method.Services;

namespace Observer_Method
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            IGenerator generator = new MessageGenerator(1, 15);
            IWriter consoleWriter = new ConsoleWriter();
            IWriter databaseWriter = new DatabaseWriter();
            IWriter loger = new Loger();
            (generator as IObservable).AddObserver(consoleWriter as IObserver);
            (generator as IObservable).AddObserver(databaseWriter as IObserver);
            (generator as IObservable).AddObserver(loger as IObserver);
            for (var i = 0; i < 3; i++)
                generator.Generate();
        }
    }
}
