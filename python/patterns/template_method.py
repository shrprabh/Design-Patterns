from abc import ABC, abstractmethod


class CaffeineBeverage(ABC):
    def prepare(self) -> None:
        self.boil_water()
        self.brew()
        self.pour_in_cup()
        self.add_condiments()

    def boil_water(self) -> None:
        print("Boil water")

    def pour_in_cup(self) -> None:
        print("Pour into cup")

    @abstractmethod
    def brew(self) -> None:
        raise NotImplementedError

    @abstractmethod
    def add_condiments(self) -> None:
        raise NotImplementedError


class Tea(CaffeineBeverage):
    def brew(self) -> None:
        print("Steep tea bag")

    def add_condiments(self) -> None:
        print("Add lemon")


class Coffee(CaffeineBeverage):
    def brew(self) -> None:
        print("Brew coffee grounds")

    def add_condiments(self) -> None:
        print("Add sugar")


def run() -> None:
    print("\nTemplate Method")
    Tea().prepare()
    Coffee().prepare()
