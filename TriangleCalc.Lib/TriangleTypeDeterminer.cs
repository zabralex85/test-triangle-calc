using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using TriangleCalc.Lib.Enums;
using TriangleCalc.Lib.Interfaces;
using TriangleCalc.Lib.Models;

namespace TriangleCalc.Lib
{
    /// <summary>
    /// Represents a class that determines the type of a triangle based on its side lengths.
    /// </summary>
    /// <remarks>
    /// This class implements the TriangleTypeDeterminerBase interface.
    /// </remarks>
    public sealed class TriangleTypeDeterminer : ITriangleTypeDeterminer
    {
        private static readonly ResourceManager ResourceManager =
            new ResourceManager("TriangleCalc.Lib.Messages", typeof(TriangleTypeDeterminer).Assembly);

        private const double Epsilon = 1e-10; // Tolerance for floating-point comparison

        /// <summary>
        /// Determines the type of triangle based on its side lengths and returns the localized result.
        /// </summary>
        /// <param name="triangle">The triangle object to determine the type for.</param>
        /// <param name="overrideCulture">The culture to use for localization.</param>
        /// <returns>The localized type of the triangle (e.g. "Equilateral", "Isosceles", "Scalene").</returns>
        public string DetermineTriangleTypeLocalized(Triangle triangle, CultureInfo? overrideCulture = null)
        {
            if (overrideCulture is null)
            {
                overrideCulture = CultureInfo.CurrentCulture;
            }

            string typeName = DetermineTriangleType(triangle).ToString();
            return ResourceManager.GetString(typeName, overrideCulture) ?? typeName;
        }

        /// <summary>
        /// Determines the type of a triangle based on its side lengths.
        /// This method is optimized for performance.
        /// </summary>
        /// <param name="triangle">The triangle object containing the side lengths.</param>
        /// <returns>The type of the triangle (equilateral, isosceles, scalene).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TriangleType DetermineTriangleType(Triangle triangle)
        {
            if (triangle.SideA <= 0 || triangle.SideB <= 0 || triangle.SideC <= 0)
            {
                return TriangleType.Invalid;
            }
            
            double sideA = triangle.SideA, sideB = triangle.SideB, sideC = triangle.SideC;
            double maxSide = sideA, minSide1 = sideB, minSide2 = sideC;

            if (sideB > maxSide)
            {
                maxSide = sideB;
                minSide1 = sideA;
                minSide2 = sideC;
            }

            if (triangle.SideC > maxSide)
            {
                maxSide = sideC;
                minSide1 = sideA;
                minSide2 = sideB;
            }

            if (minSide1 + minSide2 <= maxSide)
            {
                return TriangleType.Invalid;
            }

            unchecked
            {
                // Determine the type of the triangle
                double maxSideSquared = maxSide * maxSide;
                double sumOfSquares = minSide1 * minSide1 + minSide2 * minSide2;

                if (Math.Abs(maxSideSquared - sumOfSquares) < Epsilon)
                {
                    return TriangleType.Right;
                }

                return maxSideSquared < sumOfSquares ? TriangleType.Acute : TriangleType.Obtuse;
            }
        }
    }
}
