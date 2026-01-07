from collections.abc import Callable


class CounterViewModel:
    def __init__(self) -> None:
        self._value = 0
        self._listeners: list[Callable[[int], None]] = []

    @property
    def value(self) -> int:
        return self._value

    def bind(self, listener: Callable[[int], None]) -> None:
        self._listeners.append(listener)

    def _notify(self) -> None:
        for listener in self._listeners:
            listener(self._value)

    def increment(self) -> None:
        self._value += 1
        self._notify()


class CounterView:
    def __init__(self, view_model: CounterViewModel) -> None:
        self.view_model = view_model
        self.view_model.bind(self.render)

    def click_increment(self) -> None:
        self.view_model.increment()

    def render(self, value: int) -> None:
        print(f"View binds to: {value}")


def run() -> None:
    print("\nModel View ViewModel")
    vm = CounterViewModel()
    view = CounterView(vm)
    view.click_increment()
    view.click_increment()
