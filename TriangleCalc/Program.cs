// Create a TriangleTypeDeterminer instance

using System.Globalization;
using TriangleCalc.Lib;
using TriangleCalc.Lib.Interfaces;
using TriangleCalc.Lib.Models;

ITriangleTypeDeterminer typeDeterminer = new TriangleTypeDeterminer();

// Create triangles
Triangle acuteTriangle = new Triangle(5, 6, 7);
Triangle rightTriangle = new Triangle(3, 4, 5);
Triangle obtuseTriangle = new Triangle(6, 8, 12);

var culture = CultureInfo.GetCultureInfo("ru-RU");

// Determine and print triangle types
Console.WriteLine(@"Acute Triangle:{2}{2}{0}{2}({1})",
    $@"{acuteTriangle.SideA}|{acuteTriangle.SideB}|{acuteTriangle.SideC}",
    typeDeterminer.DetermineTriangleTypeLocalized(acuteTriangle, culture),
    '\t');

Console.WriteLine(@"Right Triangle:{2}{2}{0}{2}({1})",
    $@"{rightTriangle.SideA}|{rightTriangle.SideB}|{rightTriangle.SideC}",
    typeDeterminer.DetermineTriangleTypeLocalized(rightTriangle, culture),
    '\t');

Console.WriteLine(@"Obtuse Triangle:{2}{0}{2}({1})",
    $@"{obtuseTriangle.SideA}|{obtuseTriangle.SideB}|{obtuseTriangle.SideC}",
    typeDeterminer.DetermineTriangleTypeLocalized(obtuseTriangle, culture),
    '\t');

Console.ReadLine();