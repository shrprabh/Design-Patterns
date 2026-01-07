using System;

namespace DesignPatterns.Patterns;

public static class ChainOfResponsibility
{
    private record Ticket(int Level, string Message);

    private abstract class SupportHandler
    {
        private readonly int _maxLevel;
        private SupportHandler? _next;

        protected SupportHandler(int maxLevel)
        {
            _maxLevel = maxLevel;
        }

        public SupportHandler SetNext(SupportHandler next)
        {
            _next = next;
            return next;
        }

        public string Handle(Ticket ticket)
        {
            if (ticket.Level <= _maxLevel)
            {
                return $"Handled by {GetType().Name}: {ticket.Message}";
            }

            return _next != null ? _next.Handle(ticket) : $"No handler for: {ticket.Message}";
        }
    }

    private sealed class Bot : SupportHandler
    {
        public Bot() : base(1) { }
    }

    private sealed class Agent : SupportHandler
    {
        public Agent() : base(2) { }
    }

    private sealed class Engineer : SupportHandler
    {
        public Engineer() : base(3) { }
    }

    public static void Run()
    {
        Console.WriteLine("\nChain of Responsibility");
        var bot = new Bot();
        var agent = new Agent();
        var engineer = new Engineer();
        bot.SetNext(agent).SetNext(engineer);

        var tickets = new[]
        {
            new Ticket(1, "Password reset"),
            new Ticket(2, "App crashes sometimes"),
            new Ticket(3, "System outage"),
        };

        foreach (var ticket in tickets)
        {
            Console.WriteLine(bot.Handle(ticket));
        }
    }
}
