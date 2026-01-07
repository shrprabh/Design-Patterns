using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns;

public static class Singleton
{
    private sealed class Settings
    {
        private static readonly Settings InstanceValue = new();
        private readonly Dictionary<string, string> _values = new();

        private Settings() { }

        public static Settings Instance => InstanceValue;

        public void Set(string key, string value) => _values[key] = value;

        public string? Get(string key)
        {
            return _values.TryGetValue(key, out var value) ? value : null;
        }
    }

    public static void Run()
    {
        Console.WriteLine("\nSingleton");
        var settingsA = Settings.Instance;
        var settingsB = Settings.Instance;
        settingsA.Set("theme", "blue");
        Console.WriteLine($"Same instance: {ReferenceEquals(settingsA, settingsB)}");
        Console.WriteLine($"Theme: {settingsB.Get("theme")}");
    }
}
