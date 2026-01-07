from dataclasses import dataclass
from typing import Optional


@dataclass
class Ticket:
    level: int
    message: str


class SupportHandler:
    def __init__(self, max_level: int) -> None:
        self.max_level = max_level
        self.next_handler: Optional["SupportHandler"] = None

    def set_next(self, handler: "SupportHandler") -> "SupportHandler":
        self.next_handler = handler
        return handler

    def handle(self, ticket: Ticket) -> str:
        if ticket.level <= self.max_level:
            return f"Handled by {self.__class__.__name__}: {ticket.message}"
        if self.next_handler:
            return self.next_handler.handle(ticket)
        return f"No handler for: {ticket.message}"


class Bot(SupportHandler):
    def __init__(self) -> None:
        super().__init__(max_level=1)


class Agent(SupportHandler):
    def __init__(self) -> None:
        super().__init__(max_level=2)


class Engineer(SupportHandler):
    def __init__(self) -> None:
        super().__init__(max_level=3)


def run() -> None:
    print("\nChain of Responsibility")
    bot = Bot()
    agent = Agent()
    engineer = Engineer()
    bot.set_next(agent).set_next(engineer)

    tickets = [
        Ticket(1, "Password reset"),
        Ticket(2, "App crashes sometimes"),
        Ticket(3, "System outage"),
    ]

    for ticket in tickets:
        print(bot.handle(ticket))
