from dataclasses import dataclass
from typing import List


@dataclass
class Sandwich:
    items: List[str]

    def describe(self) -> str:
        return "Sandwich: " + ", ".join(self.items)


class SandwichBuilder:
    def __init__(self) -> None:
        self.items: List[str] = []

    def add_bread(self, kind: str) -> "SandwichBuilder":
        self.items.append(f"bread({kind})")
        return self

    def add_filling(self, filling: str) -> "SandwichBuilder":
        self.items.append(filling)
        return self

    def add_sauce(self, sauce: str) -> "SandwichBuilder":
        self.items.append(f"sauce({sauce})")
        return self

    def build(self) -> Sandwich:
        return Sandwich(self.items.copy())


class SandwichShop:
    def make_kids_sandwich(self) -> Sandwich:
        return (
            SandwichBuilder()
            .add_bread("white")
            .add_filling("peanut butter")
            .add_filling("jelly")
            .build()
        )

    def make_pro_sandwich(self) -> Sandwich:
        return (
            SandwichBuilder()
            .add_bread("sourdough")
            .add_filling("turkey")
            .add_filling("lettuce")
            .add_sauce("mustard")
            .build()
        )


def run() -> None:
    print("\nBuilder")
    shop = SandwichShop()
    print(shop.make_kids_sandwich().describe())
    print(shop.make_pro_sandwich().describe())
