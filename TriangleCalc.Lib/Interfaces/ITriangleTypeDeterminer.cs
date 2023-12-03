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
    }
}
