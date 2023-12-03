namespace TriangleCalc.Lib.Models
{

    /// <summary>
    /// Represents a triangle in 2D space with floating-point coordinates.
    /// </summary>
    public readonly struct Triangle
    {
        public readonly double SideA;
        public readonly double SideB;
        public readonly double SideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
    }
}
