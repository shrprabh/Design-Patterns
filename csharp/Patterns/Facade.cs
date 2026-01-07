using System;

namespace DesignPatterns.Patterns;

public static class Facade
{
    private class Projector
    {
        public void On() => Console.WriteLine("Projector on");
        public void Off() => Console.WriteLine("Projector off");
    }

    private class SoundSystem
    {
        public void On() => Console.WriteLine("Sound system on");
        public void Off() => Console.WriteLine("Sound system off");
    }

    private class StreamingApp
    {
        public void Play(string movie) => Console.WriteLine($"Streaming '{movie}'");
        public void Stop() => Console.WriteLine("Stop streaming");
    }

    private class MovieNightFacade
    {
        private readonly Projector _projector = new();
        private readonly SoundSystem _sound = new();
        private readonly StreamingApp _app = new();

        public void StartMovie(string movie)
        {
            _projector.On();
            _sound.On();
            _app.Play(movie);
        }

        public void EndMovie()
        {
            _app.Stop();
            _sound.Off();
            _projector.Off();
        }
    }

    public static void Run()
    {
        Console.WriteLine("\nFacade");
        var movieNight = new MovieNightFacade();
        movieNight.StartMovie("The Brave Little Toaster");
        movieNight.EndMovie();
    }
}
