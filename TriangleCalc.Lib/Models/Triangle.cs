namespace TriangleCalc.Lib.Models;

/// <summary>
/// Represents a triangle in 2D space with floating-point coordinates.
/// </summary>
public readonly struct Triangle
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
}
