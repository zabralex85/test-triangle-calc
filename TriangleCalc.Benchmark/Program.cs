using BenchmarkDotNet.Running;
using TriangleCalc.Benchmark;

BenchmarkRunner.Run<TriangleTypeBenchmark>();
Console.ReadLine();
