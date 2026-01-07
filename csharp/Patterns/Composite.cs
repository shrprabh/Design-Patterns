using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns;

public static class Composite
{
    private interface IBoxItem
    {
        decimal Price();
        string Describe(int indent = 0);
    }

    private class Toy : IBoxItem
    {
        private readonly string _name;
        private readonly decimal _cost;

        public Toy(string name, decimal cost)
        {
            _name = name;
            _cost = cost;
        }

        public decimal Price() => _cost;

        public string Describe(int indent = 0) => new string(' ', indent) + $"Toy({_name}) ${_cost:0.00}";
    }

    private class Box : IBoxItem
    {
        private readonly string _name;
        private readonly List<IBoxItem> _items = new();

        public Box(string name)
        {
            _name = name;
        }

        public void Add(IBoxItem item) => _items.Add(item);

        public decimal Price()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += item.Price();
            }
            return total;
        }

        public string Describe(int indent = 0)
        {
            var lines = new List<string> { new string(' ', indent) + $"Box({_name})" };
            foreach (var item in _items)
            {
                lines.Add(item.Describe(indent + 2));
            }
            return string.Join("\n", lines);
        }
    }

    public static void Run()
    {
        Console.WriteLine("\nComposite");
        var bigBox = new Box("Big Box");
        bigBox.Add(new Toy("Car", 5.0m));
        var smallBox = new Box("Small Box");
        smallBox.Add(new Toy("Doll", 7.5m));
        smallBox.Add(new Toy("Ball", 2.0m));
        bigBox.Add(smallBox);

        Console.WriteLine(bigBox.Describe());
        Console.WriteLine($"Total: ${bigBox.Price():0.00}");
    }
}
