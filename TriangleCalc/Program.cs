// Create a TriangleTypeDeterminerBase instance

using System;
using System.Globalization;
using TriangleCalc.Lib;
using TriangleCalc.Lib.Models;

namespace TriangleCalc
{
    public static class Program
    {
        private static readonly TriangleTypeDeterminer _typeDeterminer = new ();

        public static void Main(string[] args)
        {
            GetTriangles(1, false);
            Console.ReadLine();
        }

        private static void GetTriangles(int num, bool suppressConsole = true)
        {
            for (int i = 0; i < num; i++)
            {
                GetTriangles(5, 6, 0, suppressConsole);
            }
        }

        private static void GetTriangles(double a, double b, double c, bool suppressConsole = true)
        {
            // Create triangles
            var tiangle = new Triangle(a, b, c);

            if (suppressConsole)
            {
                _typeDeterminer.DetermineTriangleType(tiangle);
            }
            else
            {
                var culture = CultureInfo.GetCultureInfo("ru-RU");
                var result = _typeDeterminer.DetermineTriangleType(tiangle, culture);

                // Determine and print triangle types
                Console.WriteLine(@"({0}|{1}|{2}){4}({3})",
                    tiangle.SideA, tiangle.SideB, tiangle.SideC, result, '\t');
            }
        }
    }
}
