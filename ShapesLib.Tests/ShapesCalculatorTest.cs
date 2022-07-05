using Moq;
using System;
using Xunit;

namespace ShapesLib.Tests
{
    public class ShapesCalculatorTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void GetCircleArea_IncorrectRadius_ThrowArgumentException(double radius)
        {
            // Arrange
            Func<object> action = () => ShapesCalculator.GetCircleArea(radius);

            // Act, Assert
            var ex = Assert.Throws<ArgumentException>(action);
            Assert.Equal($"Incorrect circle radius {radius}", ex.Message);
        }

        [Fact]
        public void GetCircleArea_Radius2_Result4PI()
        {
            // Arrange
            var radius = 2d;
            var expectedArea = 12.566d;
            var expectedPrecision = 3;

            // Act
            var actualArea = ShapesCalculator.GetCircleArea(radius);

            // Assert
            Assert.Equal(expectedArea, actualArea, expectedPrecision);
        }
 
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 2)]
        [InlineData(1, 1, 3)]
        public void GetTriangleArea_IncorrectSides_ThrowArgumentException(double a, double b, double c)
        {
            // Arrange
            Func<object> action = () => ShapesCalculator.GetTriangleArea(a, b, c);

            // Act, Assert
            var ex = Assert.Throws<ArgumentException>(action);
            Assert.Equal($"Incorrect triangle sides {a}, {b} and {c}.", ex.Message);
        }

        [Fact]
        public void GetTriangleArea_RightAngledTriangle_SomeResult()
        {
            // Arrange
            var a = 1d;
            var b = 1d;
            var c = 1.414d;
            var expectedArea = 0.5d;
            var expectedPrecision = 2;

            // Act
            var actualArea = ShapesCalculator.GetTriangleArea(a, b, c);

            // Assert
            Assert.Equal(expectedArea, actualArea, expectedPrecision);
        }

        [Fact]
        public void GetTriangleArea_NotRightAngledTriangle_SomeResult()
        {
            // Arrange
            var a = 1d;
            var b = 1d;
            var c = 0.014d;
            var expectedArea = 0.01d;
            var expectedPrecision = 2;

            // Act
            var actualArea = ShapesCalculator.GetTriangleArea(a, b, c);

            // Assert
            Assert.Equal(expectedArea, actualArea, expectedPrecision);
        }

        [Fact]
        public void GetShapeAreaTest()
        {
            // Arrange
            var shapeMock = new Mock<Shape>();
            shapeMock.Setup(s => s.Area);

            // Act
            var actualArea = ShapesCalculator.GetShapeArea(shapeMock.Object);

            // Assert
            shapeMock.Verify(s => s.Area);
        }
    }
}
