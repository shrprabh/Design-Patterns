using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns;

public static class Observer
{
    private interface ISubscriber
    {
        void Update(string news);
    }

    private class PhoneSubscriber : ISubscriber
    {
        private readonly string _name;

        public PhoneSubscriber(string name)
        {
            _name = name;
        }

        public void Update(string news)
        {
            Console.WriteLine($"{_name} got news: {news}");
        }
    }

    private class NewsPublisher
    {
        private readonly List<ISubscriber> _subscribers = new();

        public void Subscribe(ISubscriber subscriber) => _subscribers.Add(subscriber);
        public void Unsubscribe(ISubscriber subscriber) => _subscribers.Remove(subscriber);

        public void Publish(string news)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(news);
            }
        }
    }

    public static void Run()
    {
        Console.WriteLine("\nObserver");
        var publisher = new NewsPublisher();
        var alice = new PhoneSubscriber("Alice");
        var bob = new PhoneSubscriber("Bob");

        publisher.Subscribe(alice);
        publisher.Subscribe(bob);
        publisher.Publish("Ice cream truck is here!");
    }
}
