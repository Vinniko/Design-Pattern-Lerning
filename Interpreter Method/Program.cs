using System;
using System.Collections.Generic;
using Interpreter_Method.Models;
using Interpreter_Method.Services;

namespace Interpreter_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string value = Console.ReadLine();
            string name = "word";
            var context = new Context(new Dictionary<string, string>()
            {
                {name, value},
            });
            var wordExpression = new WordExpression(name);
            var firstLetterToUpperExpression = new FirstLetterToUpperExpression(wordExpression);
            firstLetterToUpperExpression.Interpret(context);
            
            Console.WriteLine(context.getValueByName(name));
        }
    }
}