using TriangleCalc.Lib.Interfaces;
using TriangleCalc.Lib.Models;
using TriangleCalc.Lib;
using TriangleCalc.Lib.Enums;
using Xunit;

namespace TriangleCalc.Tests
{
    public class MainTests
    {
        private readonly ITriangleTypeDeterminer _typeDeterminer;

        public MainTests()
        {
            _typeDeterminer = new TriangleTypeDeterminer();
        }

        [Theory]
        [InlineData(2, 2, 5, TriangleType.Invalid)] // Invalid triangle
        [InlineData(5D, 6, 7, TriangleType.Acute)]   // Acute triangle
        [InlineData(3, 4F, 5, TriangleType.Right)]   // Right triangle
        [InlineData(6, 8D, 12F, TriangleType.Obtuse)] // Obtuse triangle
        public void CheckTriangleType(double side1, double side2, double side3, TriangleType expectedType)
        {
            // Arrange
            var triangle = new Triangle(side1, side2, side3);

            // Act
            var type = _typeDeterminer.DetermineTriangleType(triangle);

            // Assert
            Assert.Equal(expectedType, type);
        }
    }
}
