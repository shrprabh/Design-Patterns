using System;

namespace DesignPatterns.Patterns;

public static class Decorator
{
    private interface IIceCream
    {
        decimal Cost();
        string Description();
    }

    private class Vanilla : IIceCream
    {
        public decimal Cost() => 2.0m;
        public string Description() => "vanilla";
    }

    private abstract class ToppingDecorator : IIceCream
    {
        protected ToppingDecorator(IIceCream baseIceCream)
        {
            BaseIceCream = baseIceCream;
        }

        protected IIceCream BaseIceCream { get; }
        public abstract decimal Cost();
        public abstract string Description();
    }

    private class Sprinkles : ToppingDecorator
    {
        public Sprinkles(IIceCream baseIceCream) : base(baseIceCream) { }

        public override decimal Cost() => BaseIceCream.Cost() + 0.5m;
        public override string Description() => BaseIceCream.Description() + ", sprinkles";
    }

    private class Cherry : ToppingDecorator
    {
        public Cherry(IIceCream baseIceCream) : base(baseIceCream) { }

        public override decimal Cost() => BaseIceCream.Cost() + 0.75m;
        public override string Description() => BaseIceCream.Description() + ", cherry";
    }

    public static void Run()
    {
        Console.WriteLine("\nDecorator");
        IIceCream iceCream = new Vanilla();
        IIceCream fancy = new Cherry(new Sprinkles(iceCream));
        Console.WriteLine($"{fancy.Description()} costs ${fancy.Cost():0.00}");
    }
}
