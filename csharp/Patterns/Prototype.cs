using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns;

public static class Prototype
{
    private class Character
    {
        public Character(string name, List<string> skills, Dictionary<string, int> stats)
        {
            Name = name;
            Skills = skills;
            Stats = stats;
        }

        public string Name { get; set; }
        public List<string> Skills { get; }
        public Dictionary<string, int> Stats { get; }

        public Character Clone()
        {
            return new Character(Name, new List<string>(Skills), new Dictionary<string, int>(Stats));
        }

        public override string ToString()
        {
            return $"{Name} with skills [{string.Join(", ", Skills)}] and hp {Stats["hp"]}";
        }
    }

    public static void Run()
    {
        Console.WriteLine("\nPrototype");
        var original = new Character("Hero", new List<string> { "jump", "run" }, new Dictionary<string, int> { ["hp"] = 100 });
        var clone = original.Clone();
        clone.Name = "Hero 2";
        clone.Skills.Add("fly");

        Console.WriteLine($"Original: {original}");
        Console.WriteLine($"Clone: {clone}");
    }
}
