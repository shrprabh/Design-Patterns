using System;

namespace DesignPatterns.Patterns;

public static class StatePattern
{
    private interface ITrafficLightState
    {
        ITrafficLightState Next();
        string Name { get; }
    }

    private class Red : ITrafficLightState
    {
        public ITrafficLightState Next() => new Green();
        public string Name => "Red";
    }

    private class Green : ITrafficLightState
    {
        public ITrafficLightState Next() => new Yellow();
        public string Name => "Green";
    }

    private class Yellow : ITrafficLightState
    {
        public ITrafficLightState Next() => new Red();
        public string Name => "Yellow";
    }

    private class TrafficLight
    {
        private ITrafficLightState _state = new Red();

        public void Change() => _state = _state.Next();

        public void Show() => Console.WriteLine($"Light is {_state.Name}");
    }

    public static void Run()
    {
        Console.WriteLine("\nState");
        var light = new TrafficLight();
        for (var i = 0; i < 4; i++)
        {
            light.Show();
            light.Change();
        }
    }
}
