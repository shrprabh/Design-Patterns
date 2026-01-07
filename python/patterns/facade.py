class Projector:
    def on(self) -> None:
        print("Projector on")

    def off(self) -> None:
        print("Projector off")


class SoundSystem:
    def on(self) -> None:
        print("Sound system on")

    def off(self) -> None:
        print("Sound system off")


class StreamingApp:
    def play(self, movie: str) -> None:
        print(f"Streaming '{movie}'")

    def stop(self) -> None:
        print("Stop streaming")


class MovieNightFacade:
    def __init__(self) -> None:
        self.projector = Projector()
        self.sound = SoundSystem()
        self.app = StreamingApp()

    def start_movie(self, movie: str) -> None:
        self.projector.on()
        self.sound.on()
        self.app.play(movie)

    def end_movie(self) -> None:
        self.app.stop()
        self.sound.off()
        self.projector.off()


def run() -> None:
    print("\nFacade")
    movie_night = MovieNightFacade()
    movie_night.start_movie("The Brave Little Toaster")
    movie_night.end_movie()
