using System;
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
        /// Determines the type of a triangle based on its side lengths.
        /// </summary>
        /// <param name="triangle">The triangle object containing the side lengths.</param>
        /// <param name="overrideCulture">Optional parameter to override the culture.</param>
        /// <returns>A string representing the type of the triangle (equilateral, isosceles, scalene).</returns>
        public string DetermineTriangleType(Triangle triangle, CultureInfo overrideCulture = null)
        {
            var result = DetermineTriangleType(triangle);
            var typeName = GetEnglishName(result);

            if (overrideCulture is null)
            {
                return typeName;
            }

            return ResourceManager.GetString(typeName, overrideCulture) ?? typeName;
        }

        private static string GetEnglishName(TriangleType triangleType)
        {
            return triangleType switch
            {
                TriangleType.Acute => "Acute",
                TriangleType.Invalid => "Invalid",
                TriangleType.Obtuse => "Obtuse",
                TriangleType.Right => "Right",
                _ => "Invalid"
            };
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
            
            unchecked
            {
                if (minSide1 + minSide2 <= maxSide)
                {
                    return TriangleType.Invalid;
                }

                if (maxSide <= 0 || minSide1 <= 0 || minSide2 <= 0)
                {
                    return TriangleType.Invalid;
                }

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
