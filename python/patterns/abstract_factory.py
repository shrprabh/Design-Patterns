from abc import ABC, abstractmethod


class Chair(ABC):
    @abstractmethod
    def sit(self) -> str:
        raise NotImplementedError


class Sofa(ABC):
    @abstractmethod
    def nap(self) -> str:
        raise NotImplementedError


class ModernChair(Chair):
    def sit(self) -> str:
        return "Sit on a sleek modern chair"


class ModernSofa(Sofa):
    def nap(self) -> str:
        return "Nap on a clean modern sofa"


class VictorianChair(Chair):
    def sit(self) -> str:
        return "Sit on a fancy Victorian chair"


class VictorianSofa(Sofa):
    def nap(self) -> str:
        return "Nap on a cozy Victorian sofa"


class FurnitureFactory(ABC):
    @abstractmethod
    def create_chair(self) -> Chair:
        raise NotImplementedError

    @abstractmethod
    def create_sofa(self) -> Sofa:
        raise NotImplementedError


class ModernFactory(FurnitureFactory):
    def create_chair(self) -> Chair:
        return ModernChair()

    def create_sofa(self) -> Sofa:
        return ModernSofa()


class VictorianFactory(FurnitureFactory):
    def create_chair(self) -> Chair:
        return VictorianChair()

    def create_sofa(self) -> Sofa:
        return VictorianSofa()


class LivingRoom:
    def __init__(self, factory: FurnitureFactory) -> None:
        self.chair = factory.create_chair()
        self.sofa = factory.create_sofa()

    def relax(self) -> str:
        return f"{self.chair.sit()} and {self.sofa.nap()}"


def run() -> None:
    print("\nAbstract Factory")
    for factory in (ModernFactory(), VictorianFactory()):
        room = LivingRoom(factory)
        print(room.relax())
