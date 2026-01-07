class CounterModel:
    def __init__(self) -> None:
        self.value = 0

    def increment(self) -> None:
        self.value += 1


class CounterView:
    def __init__(self) -> None:
        self.presenter: "CounterPresenter" | None = None

    def set_presenter(self, presenter: "CounterPresenter") -> None:
        self.presenter = presenter

    def click_increment(self) -> None:
        if self.presenter:
            self.presenter.increment_clicked()

    def render(self, value: int) -> None:
        print(f"View shows: {value}")


class CounterPresenter:
    def __init__(self, model: CounterModel, view: CounterView) -> None:
        self.model = model
        self.view = view
        self.view.set_presenter(self)

    def increment_clicked(self) -> None:
        self.model.increment()
        self.view.render(self.model.value)


def run() -> None:
    print("\nModel View Presenter")
    model = CounterModel()
    view = CounterView()
    CounterPresenter(model, view)
    view.click_increment()
    view.click_increment()
