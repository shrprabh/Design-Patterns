import importlib
import sys

PATTERNS = {
    "abstract_factory": "abstract_factory",
    "adapter": "adapter",
    "builder": "builder",
    "chain_of_responsibility": "chain_of_responsibility",
    "command": "command",
    "composite": "composite",
    "decorator": "decorator",
    "facade": "facade",
    "factory": "factory",
    "iterator": "iterator",
    "mvc": "mvc",
    "mvp": "mvp",
    "mvvm": "mvvm",
    "observer": "observer",
    "prototype": "prototype",
    "singleton": "singleton",
    "state": "state",
    "strategy": "strategy",
    "template_method": "template_method",
}

ORDER = [
    "abstract_factory",
    "adapter",
    "builder",
    "chain_of_responsibility",
    "command",
    "composite",
    "decorator",
    "facade",
    "factory",
    "iterator",
    "mvc",
    "mvp",
    "mvvm",
    "observer",
    "prototype",
    "singleton",
    "state",
    "strategy",
    "template_method",
]


def run_pattern(key: str) -> None:
    module_name = PATTERNS[key]
    module = importlib.import_module(f"patterns.{module_name}")
    module.run()


def print_usage() -> None:
    keys = "\n  - ".join(ORDER)
    print("Usage: python main.py <pattern-key>\n")
    print("Pattern keys:\n  - " + keys)
    print("\nUse 'all' to run every pattern example.")


def main() -> None:
    if len(sys.argv) < 2:
        print_usage()
        return

    key = sys.argv[1].lower()
    if key == "all":
        for pattern in ORDER:
            run_pattern(pattern)
        return

    if key not in PATTERNS:
        print(f"Unknown pattern: {key}\n")
        print_usage()
        return

    run_pattern(key)


if __name__ == "__main__":
    main()
