using System;
using System.Collections.Generic;
using Observer_Method.Interfaces;
using Observer_Method.Models;

namespace Observer_Method.Services
{
    public sealed class MessageGenerator : IGenerator, IObservable
    {
        public MessageGenerator(int minMassageLength, int maxMessageLength)
        {
            _observers = new List<IObserver>();
            _minMessageLength = minMassageLength;
            _maxMessageLength = maxMessageLength;
        }

        public void Generate()
        {
            Random random = new Random();
            Message message = new Message();
            message.Id = _lastId++;
            int message_length = random.Next(_minMessageLength, _maxMessageLength);
            for(var i = 0; i < message_length; i++)
            {
                message.Text += _alphabet[random.Next(0, _alphabet.Length)];
            }
            NotifyObservers(message);
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers(IModel model)
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update(model);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private int _minMessageLength;
        private int _maxMessageLength;
        private int _lastId = 0;
        private const string _alphabet = "abcdefghijklmnopqrstuvwxyz 1234567890!@#$%^&*()_+-={}[];':,.<>/?";
        private List<IObserver> _observers;
    }
}
