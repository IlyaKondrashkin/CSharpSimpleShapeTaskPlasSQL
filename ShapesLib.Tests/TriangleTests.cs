using System;
using Xunit;

namespace ShapesLib.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 1, 2)]
        [InlineData(1, 1, 3)]
        public void CreateTriangle_IncorrectSides_ThrowArgumentException(
            double a, double b, double c)
        {
            // Arrange
            Func<object> action = () => new Triangle(a, b, c);

            // Act, Assert
            var ex = Assert.Throws<ArgumentException>(action);
            Assert.Equal($"Incorrect triangle sides {a}, {b} and {c}.", ex.Message);
        }

        [Fact]
        public void Area_RightAngledTriangle_SomeResult()
        {
            // Arrange
            var a = 1d;
            var b = 1d;
            var c = 1.414d;
            var triangle = new Triangle(a, b, c);
            var expectedArea = 0.5d;
            var expectedPrecision = 2;

            // Act
            var actualArea = triangle.Area;

            // Assert
            Assert.Equal(expectedArea, actualArea, expectedPrecision);
        }

        [Fact]
        public void Area_NotRightAngledTriangle_SomeResult()
        {
            // Arrange
            var a = 1d;
            var b = 1d;
            var c = 0.014d;
            var triangle = new Triangle(a, b, c);
            var expectedArea = 0.01d;
            var expectedPrecision = 2;

            // Act
            var actualArea = triangle.Area;

            // Assert
            Assert.Equal(expectedArea, actualArea, expectedPrecision);
        }

        [Fact]
        public void IsRightAngled_RightAngledTriang_True()
        {
            // Arrange
            var a = 1d;
            var b = 1d;
            var c = 1.414d;
            var triangle = new Triangle(a, b, c);
            var expectedPrecision = 2;

            // Act
            var actualIsRightAngled = triangle.IsRightAngled(expectedPrecision);

            // Assert
            Assert.True(actualIsRightAngled);
        }

        [Fact]
        public void IsRightAngled_NotRightAngledTriangle_False()
        {
            // Arrange
            var a = 1d;
            var b = 1d;
            var c = 0.014d;
            var triangle = new Triangle(a, b, c);
            var expectedPrecision = 2;

            // Act
            var actualIsRightAngled = triangle.IsRightAngled(expectedPrecision);

            // Assert
            Assert.False(actualIsRightAngled);
        }
    }
}
