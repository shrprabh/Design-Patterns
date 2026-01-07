using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Patterns;

public static class IteratorPattern
{
    private class Playlist : IEnumerable<string>
    {
        private readonly List<string> _songs;

        public Playlist(IEnumerable<string> songs)
        {
            _songs = new List<string>(songs);
        }

        public IEnumerator<string> GetEnumerator() => new PlaylistIterator(_songs);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    private class PlaylistIterator : IEnumerator<string>
    {
        private readonly List<string> _songs;
        private int _index = -1;

        public PlaylistIterator(List<string> songs)
        {
            _songs = songs;
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _songs.Count;
        }

        public void Reset() => _index = -1;

        public string Current => _songs[_index];
        object IEnumerator.Current => Current;

        public void Dispose() { }
    }

    public static void Run()
    {
        Console.WriteLine("\nIterator");
        var playlist = new Playlist(new[] { "Song A", "Song B", "Song C" });
        foreach (var song in playlist)
        {
            Console.WriteLine($"Playing {song}");
        }
    }
}
