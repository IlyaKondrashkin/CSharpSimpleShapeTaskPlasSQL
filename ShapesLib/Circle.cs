using System;

namespace ShapesLib
{
    public class Circle : AbstractShape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (!IsRadiusCorrect(radius))
            {
                throw new ArgumentException($"Incorrect circle radius {radius}");
            }

            Radius = radius;
        }

        protected override double CalculateArea() =>
            Math.PI * Math.Pow(Radius, 2);

        private bool IsRadiusCorrect(double radius) =>
            radius > 0;
     }
}
