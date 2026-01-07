using System;

namespace DesignPatterns.Patterns;

public static class Strategy
{
    private interface IPaymentStrategy
    {
        string Pay(decimal amount);
    }

    private class CardPayment : IPaymentStrategy
    {
        public string Pay(decimal amount) => $"Paid ${amount:0.00} with card";
    }

    private class CashPayment : IPaymentStrategy
    {
        public string Pay(decimal amount) => $"Paid ${amount:0.00} with cash";
    }

    private class Checkout
    {
        private readonly IPaymentStrategy _strategy;

        public Checkout(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public string Complete(decimal amount) => _strategy.Pay(amount);
    }

    public static void Run()
    {
        Console.WriteLine("\nStrategy");
        Console.WriteLine(new Checkout(new CardPayment()).Complete(15m));
        Console.WriteLine(new Checkout(new CashPayment()).Complete(15m));
    }
}
