
namespace ShapesLib
{
    public static class ShapesCalculator
    {
        /// <summary>
        /// Calculate a circle area by its radius.
        /// </summary>
        public static double GetCircleArea(double radius) =>
            new Circle(radius).Area;

        /// <summary>
        /// Calculate a triangle area by its sides.
        /// </summary>
        public static double GetTriangleArea(double a, double b, double c) =>
            new Triangle(a, b, c).Area;

        /// <summary>
        /// Calculate shape area which type is unknown on compile-time.
        /// </summary>
        public static double GetShapeArea(Shape shape) =>
            shape.Area;
    }
}
