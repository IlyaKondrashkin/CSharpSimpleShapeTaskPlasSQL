
using System;
using System.Collections.Generic;

namespace ShapesLib
{
    public class Triangle : AbstractShape
    {
        private const int DEFAULT_CHECK_PRECISION = 14;

        public (double a, double b, double c) Sides { get; private set; }

        public Triangle((double a, double b, double c) sides)
        {
            if (!AreSidesCorrect(sides.a, sides.b, sides.c))
            {
                throw new ArgumentException($"Incorrect triangle sides {sides.a}, {sides.b} and {sides.c}.");
            }

            Sides = sides;
        }

        public Triangle(double a, double b, double c) : this((a, b, c))
        {
        }

        public bool IsRightAngled(int precision = DEFAULT_CHECK_PRECISION)
        {
            var sortedSides = new List<double>() { Sides.a, Sides.b, Sides.c };
            sortedSides.Sort();

            if (Math.Round(sortedSides[2], precision, MidpointRounding.AwayFromZero) ==
                Math.Round(sortedSides[1], precision, MidpointRounding.AwayFromZero))
            {
                return false;
            }

            var legsSqSum = Math.Round(sortedSides[0] * sortedSides[0] + sortedSides[1] * sortedSides[1],
                precision, MidpointRounding.AwayFromZero);
            var hypotenuseSq = Math.Round(sortedSides[2] * sortedSides[2],
                precision, MidpointRounding.AwayFromZero);

            return legsSqSum == hypotenuseSq;
        }

        protected override double CalculateArea()
        {
            var p = (Sides.a + Sides.b + Sides.c) / 2;
            return Math.Sqrt(p * (p - Sides.a) * (p - Sides.b) * (p - Sides.c));
        }

        private bool AreSidesCorrect(double a, double b, double c) =>
            a > 0 && b > 0 && c > 0 &&
            a < (b + c) && b < (a + c) && c < (a + b);
    }
}
