from abc import ABC, abstractmethod


class Command(ABC):
    @abstractmethod
    def execute(self) -> None:
        raise NotImplementedError


class Light:
    def on(self) -> None:
        print("Light is ON")

    def off(self) -> None:
        print("Light is OFF")


class LightOnCommand(Command):
    def __init__(self, light: Light) -> None:
        self.light = light

    def execute(self) -> None:
        self.light.on()


class LightOffCommand(Command):
    def __init__(self, light: Light) -> None:
        self.light = light

    def execute(self) -> None:
        self.light.off()


class RemoteControl:
    def __init__(self) -> None:
        self.on_command: Command | None = None
        self.off_command: Command | None = None

    def set_commands(self, on_command: Command, off_command: Command) -> None:
        self.on_command = on_command
        self.off_command = off_command

    def press_on(self) -> None:
        if self.on_command:
            self.on_command.execute()

    def press_off(self) -> None:
        if self.off_command:
            self.off_command.execute()


def run() -> None:
    print("\nCommand")
    light = Light()
    remote = RemoteControl()
    remote.set_commands(LightOnCommand(light), LightOffCommand(light))
    remote.press_on()
    remote.press_off()
