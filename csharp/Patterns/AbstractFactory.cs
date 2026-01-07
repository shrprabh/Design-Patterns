using System;

namespace DesignPatterns.Patterns;

public static class AbstractFactory
{
    private interface IChair
    {
        string Sit();
    }

    private interface ISofa
    {
        string Nap();
    }

    private class ModernChair : IChair
    {
        public string Sit() => "Sit on a sleek modern chair";
    }

    private class ModernSofa : ISofa
    {
        public string Nap() => "Nap on a clean modern sofa";
    }

    private class VictorianChair : IChair
    {
        public string Sit() => "Sit on a fancy Victorian chair";
    }

    private class VictorianSofa : ISofa
    {
        public string Nap() => "Nap on a cozy Victorian sofa";
    }

    private interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }

    private class ModernFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();
        public ISofa CreateSofa() => new ModernSofa();
    }

    private class VictorianFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new VictorianChair();
        public ISofa CreateSofa() => new VictorianSofa();
    }

    private class LivingRoom
    {
        private readonly IChair _chair;
        private readonly ISofa _sofa;

        public LivingRoom(IFurnitureFactory factory)
        {
            _chair = factory.CreateChair();
            _sofa = factory.CreateSofa();
        }

        public string Relax() => $"{_chair.Sit()} and {_sofa.Nap()}";
    }

    public static void Run()
    {
        Console.WriteLine("\nAbstract Factory");
        foreach (var factory in new IFurnitureFactory[] { new ModernFactory(), new VictorianFactory() })
        {
            var room = new LivingRoom(factory);
            Console.WriteLine(room.Relax());
        }
    }
}
