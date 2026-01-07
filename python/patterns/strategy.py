from abc import ABC, abstractmethod


class PaymentStrategy(ABC):
    @abstractmethod
    def pay(self, amount: float) -> str:
        raise NotImplementedError


class CardPayment(PaymentStrategy):
    def pay(self, amount: float) -> str:
        return f"Paid ${amount:.2f} with card"


class CashPayment(PaymentStrategy):
    def pay(self, amount: float) -> str:
        return f"Paid ${amount:.2f} with cash"


class Checkout:
    def __init__(self, strategy: PaymentStrategy) -> None:
        self.strategy = strategy

    def complete(self, amount: float) -> str:
        return self.strategy.pay(amount)


def run() -> None:
    print("\nStrategy")
    print(Checkout(CardPayment()).complete(15.0))
    print(Checkout(CashPayment()).complete(15.0))
