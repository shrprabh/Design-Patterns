using System;

namespace DesignPatterns.Patterns;

public static class TemplateMethod
{
    private abstract class CaffeineBeverage
    {
        public void Prepare()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        private void BoilWater() => Console.WriteLine("Boil water");
        private void PourInCup() => Console.WriteLine("Pour into cup");
        protected abstract void Brew();
        protected abstract void AddCondiments();
    }

    private class Tea : CaffeineBeverage
    {
        protected override void Brew() => Console.WriteLine("Steep tea bag");
        protected override void AddCondiments() => Console.WriteLine("Add lemon");
    }

    private class Coffee : CaffeineBeverage
    {
        protected override void Brew() => Console.WriteLine("Brew coffee grounds");
        protected override void AddCondiments() => Console.WriteLine("Add sugar");
    }

    public static void Run()
    {
        Console.WriteLine("\nTemplate Method");
        new Tea().Prepare();
        new Coffee().Prepare();
    }
}
