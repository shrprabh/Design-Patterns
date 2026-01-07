from abc import ABC, abstractmethod
from typing import List


class Subscriber(ABC):
    @abstractmethod
    def update(self, news: str) -> None:
        raise NotImplementedError


class PhoneSubscriber(Subscriber):
    def __init__(self, name: str) -> None:
        self.name = name

    def update(self, news: str) -> None:
        print(f"{self.name} got news: {news}")


class NewsPublisher:
    def __init__(self) -> None:
        self.subscribers: List[Subscriber] = []

    def subscribe(self, subscriber: Subscriber) -> None:
        self.subscribers.append(subscriber)

    def unsubscribe(self, subscriber: Subscriber) -> None:
        self.subscribers.remove(subscriber)

    def publish(self, news: str) -> None:
        for subscriber in self.subscribers:
            subscriber.update(news)


def run() -> None:
    print("\nObserver")
    publisher = NewsPublisher()
    alice = PhoneSubscriber("Alice")
    bob = PhoneSubscriber("Bob")

    publisher.subscribe(alice)
    publisher.subscribe(bob)
    publisher.publish("Ice cream truck is here!")
