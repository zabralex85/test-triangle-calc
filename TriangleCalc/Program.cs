// Create a TriangleTypeDeterminerBase instance

using System.Globalization;
using TriangleCalc.Lib;
using TriangleCalc.Lib.Models;

var typeDeterminer = new TriangleTypeDeterminer();

// Create triangles
var acuteTriangle = new Triangle(5F, 6D, 7);
var rightTriangle = new Triangle(3D, 4, 5);
var obtuseTriangle = new Triangle(6F, 8, 12);

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
