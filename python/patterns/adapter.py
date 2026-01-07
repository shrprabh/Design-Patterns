import math


class RoundPeg:
    def __init__(self, radius: float) -> None:
        self.radius = radius


class RoundHole:
    def __init__(self, radius: float) -> None:
        self.radius = radius

    def fits(self, peg: RoundPeg) -> bool:
        return peg.radius <= self.radius


class SquarePeg:
    def __init__(self, width: float) -> None:
        self.width = width


class SquarePegAdapter(RoundPeg):
    def __init__(self, peg: SquarePeg) -> None:
        self.peg = peg
        super().__init__(self._radius())

    def _radius(self) -> float:
        return self.peg.width * math.sqrt(2) / 2


def run() -> None:
    print("\nAdapter")
    hole = RoundHole(5)
    small_square = SquarePeg(5)
    big_square = SquarePeg(10)

    print("Small square fits:", hole.fits(SquarePegAdapter(small_square)))
    print("Big square fits:", hole.fits(SquarePegAdapter(big_square)))
