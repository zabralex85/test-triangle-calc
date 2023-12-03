using System;
using BenchmarkDotNet.Running;

namespace TriangleCalc.Benchmark
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<TriangleTypeBenchmark>();
            Console.ReadLine();
        }
    }
}
