using System;
using System.Collections.Generic;
using DesignPatterns.Patterns;

namespace DesignPatterns;

public static class Program
{
    private static readonly string[] Order =
    {
        "abstract_factory",
        "adapter",
        "builder",
        "chain_of_responsibility",
        "command",
        "composite",
        "decorator",
        "facade",
        "factory",
        "iterator",
        "mvc",
        "mvp",
        "mvvm",
        "observer",
        "prototype",
        "singleton",
        "state",
        "strategy",
        "template_method",
    };

    private static readonly Dictionary<string, Action> Runners = new(StringComparer.OrdinalIgnoreCase)
    {
        ["abstract_factory"] = AbstractFactory.Run,
        ["adapter"] = Adapter.Run,
        ["builder"] = Builder.Run,
        ["chain_of_responsibility"] = ChainOfResponsibility.Run,
        ["command"] = CommandPattern.Run,
        ["composite"] = Composite.Run,
        ["decorator"] = Decorator.Run,
        ["facade"] = Facade.Run,
        ["factory"] = FactoryMethod.Run,
        ["iterator"] = IteratorPattern.Run,
        ["mvc"] = Mvc.Run,
        ["mvp"] = Mvp.Run,
        ["mvvm"] = Mvvm.Run,
        ["observer"] = Observer.Run,
        ["prototype"] = Prototype.Run,
        ["singleton"] = Singleton.Run,
        ["state"] = StatePattern.Run,
        ["strategy"] = Strategy.Run,
        ["template_method"] = TemplateMethod.Run,
    };

    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            PrintUsage();
            return;
        }

        var key = args[0];
        if (key.Equals("all", StringComparison.OrdinalIgnoreCase))
        {
            foreach (var pattern in Order)
            {
                Runners[pattern]();
            }
            return;
        }

        if (!Runners.TryGetValue(key, out var action))
        {
            Console.WriteLine($"Unknown pattern: {key}\n");
            PrintUsage();
            return;
        }

        action();
    }

    private static void PrintUsage()
    {
        Console.WriteLine("Usage: dotnet run -- <pattern-key>\n");
        Console.WriteLine("Pattern keys:");
        foreach (var pattern in Order)
        {
            Console.WriteLine($"  - {pattern}");
        }
        Console.WriteLine("\nUse 'all' to run every pattern example.");
    }
}
