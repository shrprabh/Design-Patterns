import copy
from dataclasses import dataclass
from typing import Dict, List


@dataclass
class Character:
    name: str
    skills: List[str]
    stats: Dict[str, int]

    def clone(self) -> "Character":
        return copy.deepcopy(self)


def run() -> None:
    print("\nPrototype")
    original = Character("Hero", ["jump", "run"], {"hp": 100})
    clone = original.clone()
    clone.name = "Hero 2"
    clone.skills.append("fly")

    print(f"Original: {original}")
    print(f"Clone: {clone}")
