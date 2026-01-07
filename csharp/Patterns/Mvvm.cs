using System;

namespace DesignPatterns.Patterns;

public static class Mvvm
{
    private class CounterViewModel
    {
        public int Value { get; private set; }

        public event Action<int>? Changed;

        public void Increment()
        {
            Value++;
            Changed?.Invoke(Value);
        }
    }

    private class CounterView
    {
        private readonly CounterViewModel _viewModel;

        public CounterView(CounterViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.Changed += Render;
        }

        public void ClickIncrement() => _viewModel.Increment();

        private void Render(int value)
        {
            Console.WriteLine($"View binds to: {value}");
        }
    }

    public static void Run()
    {
        Console.WriteLine("\nModel View ViewModel");
        var viewModel = new CounterViewModel();
        var view = new CounterView(viewModel);
        view.ClickIncrement();
        view.ClickIncrement();
    }
}
