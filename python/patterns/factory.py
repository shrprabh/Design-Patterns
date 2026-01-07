from abc import ABC, abstractmethod


class Transport(ABC):
    @abstractmethod
    def deliver(self) -> str:
        raise NotImplementedError


class Truck(Transport):
    def deliver(self) -> str:
        return "Deliver by road"


class Ship(Transport):
    def deliver(self) -> str:
        return "Deliver by sea"


class Logistics(ABC):
    @abstractmethod
    def create_transport(self) -> Transport:
        raise NotImplementedError

    def plan_delivery(self) -> str:
        transport = self.create_transport()
        return transport.deliver()


class RoadLogistics(Logistics):
    def create_transport(self) -> Transport:
        return Truck()


class SeaLogistics(Logistics):
    def create_transport(self) -> Transport:
        return Ship()


def run() -> None:
    print("\nFactory Method")
    for logistics in (RoadLogistics(), SeaLogistics()):
        print(logistics.plan_delivery())
