using System;

namespace DesignPatterns.Patterns;

public static class FactoryMethod
{
    private interface ITransport
    {
        string Deliver();
    }

    private class Truck : ITransport
    {
        public string Deliver() => "Deliver by road";
    }

    private class Ship : ITransport
    {
        public string Deliver() => "Deliver by sea";
    }

    private abstract class Logistics
    {
        protected abstract ITransport CreateTransport();

        public string PlanDelivery()
        {
            var transport = CreateTransport();
            return transport.Deliver();
        }
    }

    private sealed class RoadLogistics : Logistics
    {
        protected override ITransport CreateTransport() => new Truck();
    }

    private sealed class SeaLogistics : Logistics
    {
        protected override ITransport CreateTransport() => new Ship();
    }

    public static void Run()
    {
        Console.WriteLine("\nFactory Method");
        foreach (var logistics in new Logistics[] { new RoadLogistics(), new SeaLogistics() })
        {
            Console.WriteLine(logistics.PlanDelivery());
        }
    }
}
