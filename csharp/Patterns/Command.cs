using System;

namespace DesignPatterns.Patterns;

public static class CommandPattern
{
    private interface ICommand
    {
        void Execute();
    }

    private class Light
    {
        public void On() => Console.WriteLine("Light is ON");
        public void Off() => Console.WriteLine("Light is OFF");
    }

    private class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute() => _light.On();
    }

    private class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute() => _light.Off();
    }

    private class RemoteControl
    {
        private ICommand? _onCommand;
        private ICommand? _offCommand;

        public void SetCommands(ICommand onCommand, ICommand offCommand)
        {
            _onCommand = onCommand;
            _offCommand = offCommand;
        }

        public void PressOn() => _onCommand?.Execute();
        public void PressOff() => _offCommand?.Execute();
    }

    public static void Run()
    {
        Console.WriteLine("\nCommand");
        var light = new Light();
        var remote = new RemoteControl();
        remote.SetCommands(new LightOnCommand(light), new LightOffCommand(light));
        remote.PressOn();
        remote.PressOff();
    }
}
