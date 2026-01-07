using System;

namespace DesignPatterns.Patterns;

public static class Mvc
{
    private class CounterModel
    {
        public int Value { get; private set; }

        public void Increment() => Value++;
    }

    private class CounterView
    {
        public void Render(int value) => Console.WriteLine($"Counter value: {value}");
    }

    private class CounterController
    {
        private readonly CounterModel _model;
        private readonly CounterView _view;

        public CounterController(CounterModel model, CounterView view)
        {
            _model = model;
            _view = view;
        }

        public void Increment()
        {
            _model.Increment();
            _view.Render(_model.Value);
        }
    }

    public static void Run()
    {
        Console.WriteLine("\nModel View Controller");
        var model = new CounterModel();
        var view = new CounterView();
        var controller = new CounterController(model, view);
        controller.Increment();
        controller.Increment();
    }
}
