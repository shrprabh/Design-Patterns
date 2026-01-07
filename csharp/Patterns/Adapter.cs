using System;

namespace DesignPatterns.Patterns;

public static class Adapter
{
    private interface IRoundPeg
    {
        double Radius { get; }
    }

    private class RoundPeg : IRoundPeg
    {
        public RoundPeg(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }
    }

    private class RoundHole
    {
        public RoundHole(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public bool Fits(IRoundPeg peg) => peg.Radius <= Radius;
    }

    private class SquarePeg
    {
        public SquarePeg(double width)
        {
            Width = width;
        }

        public double Width { get; }
    }

    private class SquarePegAdapter : IRoundPeg
    {
        private readonly SquarePeg _peg;

        public SquarePegAdapter(SquarePeg peg)
        {
            _peg = peg;
        }

        public double Radius => _peg.Width * Math.Sqrt(2) / 2;
    }

    public static void Run()
    {
        Console.WriteLine("\nAdapter");
        var hole = new RoundHole(5);
        var smallSquare = new SquarePeg(5);
        var bigSquare = new SquarePeg(10);

        Console.WriteLine($"Small square fits: {hole.Fits(new SquarePegAdapter(smallSquare))}");
        Console.WriteLine($"Big square fits: {hole.Fits(new SquarePegAdapter(bigSquare))}");
    }
}
