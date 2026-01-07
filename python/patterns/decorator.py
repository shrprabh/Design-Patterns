from abc import ABC, abstractmethod


class IceCream(ABC):
    @abstractmethod
    def cost(self) -> float:
        raise NotImplementedError

    @abstractmethod
    def description(self) -> str:
        raise NotImplementedError


class Vanilla(IceCream):
    def cost(self) -> float:
        return 2.0

    def description(self) -> str:
        return "vanilla"


class ToppingDecorator(IceCream):
    def __init__(self, base: IceCream) -> None:
        self.base = base


class Sprinkles(ToppingDecorator):
    def cost(self) -> float:
        return self.base.cost() + 0.5

    def description(self) -> str:
        return self.base.description() + ", sprinkles"


class Cherry(ToppingDecorator):
    def cost(self) -> float:
        return self.base.cost() + 0.75

    def description(self) -> str:
        return self.base.description() + ", cherry"


def run() -> None:
    print("\nDecorator")
    ice_cream = Vanilla()
    fancy = Cherry(Sprinkles(ice_cream))
    print(f"{fancy.description()} costs ${fancy.cost():.2f}")
