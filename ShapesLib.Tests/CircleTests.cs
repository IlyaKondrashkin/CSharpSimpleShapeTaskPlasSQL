using System;
using Xunit;

namespace ShapesLib.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CreateCircle_IncorrectRadius_ThrowArgumentException(double radius)
        {
            // Arrange
            Func<object> action = () => new Circle(radius);

            // Act, Assert
            var ex = Assert.Throws<ArgumentException>(action);
            Assert.Equal($"Incorrect circle radius {radius}", ex.Message);
        }

        [Fact]
        public void Area_Radius1_ResultPI()
        {
            // Arrange
            var circle = new Circle(1);
            var expectedArea = 3.142;
            var expectedPrecision = 3;

            // Act
            var actualArea = circle.Area;

            // Assert
            Assert.Equal(expectedArea, actualArea, expectedPrecision);
        }
    }
}
