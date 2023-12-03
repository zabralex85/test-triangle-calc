using System.Globalization;
using TriangleCalc.Lib.Enums;
using TriangleCalc.Lib.Models;

namespace TriangleCalc.Lib.Interfaces
{
    /// <summary>
    /// Interface for determining the type of a triangle.
    /// </summary>

    public interface ITriangleTypeDeterminer
    {
        /// <summary>
        /// Determines the type of a triangle based on its side lengths.
        /// </summary>
        /// <param name="triangle">The triangle to determine the type of.</param>
        /// <returns>The type of the triangle (Acute, Right, Obtuse).</returns>
        TriangleType DetermineTriangleType(Triangle triangle);

        /// <summary>
        /// Determines the type of a triangle based on its side lengths and returns the localized result.
        /// </summary>
        /// <param name="triangle">The triangle to determine the type of.</param>
        /// <returns>The localized type of the triangle (e.g. Acute, Right, Obtuse).</returns>
        string DetermineTriangleTypeLocalized(Triangle triangle);

        /// <summary>
        /// Determines the type of a triangle based on its side lengths and returns the localized result.
        /// </summary>
        /// <param name="triangle">The triangle object containing the side lengths.</param>
        /// <param name="culture">The culture used to localize the result.</param>
        /// <returns>The localized type of the triangle (e.g. Acute, Right, Obtuse).</returns>
        string DetermineTriangleTypeLocalized(Triangle triangle, CultureInfo culture);
    }
}
