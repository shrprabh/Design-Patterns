class Settings:
    _instance = None

    def __new__(cls) -> "Settings":
        if cls._instance is None:
            cls._instance = super().__new__(cls)
            cls._instance.values = {}
        return cls._instance

    def set(self, key: str, value: str) -> None:
        self.values[key] = value

    def get(self, key: str) -> str | None:
        return self.values.get(key)


def run() -> None:
    print("\nSingleton")
    settings_a = Settings()
    settings_b = Settings()
    settings_a.set("theme", "blue")
    print("Same instance:", settings_a is settings_b)
    print("Theme:", settings_b.get("theme"))
