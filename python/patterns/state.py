from abc import ABC, abstractmethod


class TrafficLightState(ABC):
    @abstractmethod
    def next(self) -> "TrafficLightState":
        raise NotImplementedError

    @abstractmethod
    def color(self) -> str:
        raise NotImplementedError


class Red(TrafficLightState):
    def next(self) -> TrafficLightState:
        return Green()

    def color(self) -> str:
        return "Red"


class Green(TrafficLightState):
    def next(self) -> TrafficLightState:
        return Yellow()

    def color(self) -> str:
        return "Green"


class Yellow(TrafficLightState):
    def next(self) -> TrafficLightState:
        return Red()

    def color(self) -> str:
        return "Yellow"


class TrafficLight:
    def __init__(self) -> None:
        self.state: TrafficLightState = Red()

    def change(self) -> None:
        self.state = self.state.next()

    def show(self) -> None:
        print(f"Light is {self.state.color()}")


def run() -> None:
    print("\nState")
    light = TrafficLight()
    for _ in range(4):
        light.show()
        light.change()
