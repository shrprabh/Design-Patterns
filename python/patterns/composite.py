from abc import ABC, abstractmethod
from typing import List


class BoxItem(ABC):
    @abstractmethod
    def price(self) -> float:
        raise NotImplementedError

    @abstractmethod
    def describe(self, indent: int = 0) -> str:
        raise NotImplementedError


class Toy(BoxItem):
    def __init__(self, name: str, cost: float) -> None:
        self.name = name
        self.cost = cost

    def price(self) -> float:
        return self.cost

    def describe(self, indent: int = 0) -> str:
        return " " * indent + f"Toy({self.name}) ${self.cost:.2f}"


class Box(BoxItem):
    def __init__(self, name: str) -> None:
        self.name = name
        self.items: List[BoxItem] = []

    def add(self, item: BoxItem) -> None:
        self.items.append(item)

    def price(self) -> float:
        return sum(item.price() for item in self.items)

    def describe(self, indent: int = 0) -> str:
        lines = [" " * indent + f"Box({self.name})"]
        for item in self.items:
            lines.append(item.describe(indent + 2))
        return "\n".join(lines)


def run() -> None:
    print("\nComposite")
    big_box = Box("Big Box")
    big_box.add(Toy("Car", 5.0))
    small_box = Box("Small Box")
    small_box.add(Toy("Doll", 7.5))
    small_box.add(Toy("Ball", 2.0))
    big_box.add(small_box)

    print(big_box.describe())
    print(f"Total: ${big_box.price():.2f}")
