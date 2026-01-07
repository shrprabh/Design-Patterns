class CounterModel:
    def __init__(self) -> None:
        self.value = 0

    def increment(self) -> None:
        self.value += 1


class CounterView:
    def render(self, value: int) -> None:
        print(f"Counter value: {value}")


class CounterController:
    def __init__(self, model: CounterModel, view: CounterView) -> None:
        self.model = model
        self.view = view

    def increment(self) -> None:
        self.model.increment()
        self.view.render(self.model.value)


def run() -> None:
    print("\nModel View Controller")
    model = CounterModel()
    view = CounterView()
    controller = CounterController(model, view)
    controller.increment()
    controller.increment()
