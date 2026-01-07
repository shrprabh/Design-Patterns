using System;

namespace DesignPatterns.Patterns;

public static class Mvp
{
    private class CounterModel
    {
        public int Value { get; private set; }

        public void Increment() => Value++;
    }

    private interface ICounterView
    {
        void SetPresenter(CounterPresenter presenter);
        void Render(int value);
    }

    private class CounterView : ICounterView
    {
        private CounterPresenter? _presenter;

        public void SetPresenter(CounterPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ClickIncrement()
        {
            _presenter?.IncrementClicked();
        }

        public void Render(int value)
        {
            Console.WriteLine($"View shows: {value}");
        }
    }

    private class CounterPresenter
    {
        private readonly CounterModel _model;
        private readonly ICounterView _view;

        public CounterPresenter(CounterModel model, ICounterView view)
        {
            _model = model;
            _view = view;
            _view.SetPresenter(this);
        }

        public void IncrementClicked()
        {
            _model.Increment();
            _view.Render(_model.Value);
        }
    }

    public static void Run()
    {
        Console.WriteLine("\nModel View Presenter");
        var model = new CounterModel();
        var view = new CounterView();
        _ = new CounterPresenter(model, view);
        view.ClickIncrement();
        view.ClickIncrement();
    }
}
