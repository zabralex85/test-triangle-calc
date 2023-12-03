namespace TriangleCalc.Lib.Models
{
    /// <summary>
    /// Represents a triangle with three sides.
    /// </summary>
    /// <param name="sideA">The length of side A.</param>
    /// <param name="sideB">The length of side B.</param>
    /// <param name="sideC">The length of side C.</param>
    /// <returns>
    /// An instance of the Triangle class with the specified side lengths.
    /// </returns>
    public class Triangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        /// <summary>
        /// Initializes a new instance of the Triangle class with the specified side lengths.
        /// </summary>
        /// <param name="sideA">The length of side A.</param>
        /// <param name="sideB">The length of side B.</param>
        /// <param name="sideC">The length of side C.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
    }
}
