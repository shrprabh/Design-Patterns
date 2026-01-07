using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns;

public static class Builder
{
    private class Sandwich
    {
        private readonly List<string> _items;

        public Sandwich(List<string> items)
        {
            _items = items;
        }

        public string Describe() => "Sandwich: " + string.Join(", ", _items);
    }

    private class SandwichBuilder
    {
        private readonly List<string> _items = new();

        public SandwichBuilder AddBread(string kind)
        {
            _items.Add($"bread({kind})");
            return this;
        }

        public SandwichBuilder AddFilling(string filling)
        {
            _items.Add(filling);
            return this;
        }

        public SandwichBuilder AddSauce(string sauce)
        {
            _items.Add($"sauce({sauce})");
            return this;
        }

        public Sandwich Build() => new(new List<string>(_items));
    }

    private class SandwichShop
    {
        public Sandwich MakeKidsSandwich() =>
            new SandwichBuilder()
                .AddBread("white")
                .AddFilling("peanut butter")
                .AddFilling("jelly")
                .Build();

        public Sandwich MakeProSandwich() =>
            new SandwichBuilder()
                .AddBread("sourdough")
                .AddFilling("turkey")
                .AddFilling("lettuce")
                .AddSauce("mustard")
                .Build();
    }

    public static void Run()
    {
        Console.WriteLine("\nBuilder");
        var shop = new SandwichShop();
        Console.WriteLine(shop.MakeKidsSandwich().Describe());
        Console.WriteLine(shop.MakeProSandwich().Describe());
    }
}
