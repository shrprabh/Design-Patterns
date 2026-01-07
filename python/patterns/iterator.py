class PlaylistIterator:
    def __init__(self, songs: list[str]) -> None:
        self.songs = songs
        self.index = 0

    def __iter__(self) -> "PlaylistIterator":
        return self

    def __next__(self) -> str:
        if self.index >= len(self.songs):
            raise StopIteration
        song = self.songs[self.index]
        self.index += 1
        return song


class Playlist:
    def __init__(self, songs: list[str]) -> None:
        self.songs = songs

    def __iter__(self) -> PlaylistIterator:
        return PlaylistIterator(self.songs)


def run() -> None:
    print("\nIterator")
    playlist = Playlist(["Song A", "Song B", "Song C"])
    for song in playlist:
        print(f"Playing {song}")
