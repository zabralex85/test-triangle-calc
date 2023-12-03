using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using TriangleCalc.Lib;
using TriangleCalc.Lib.Interfaces;
using TriangleCalc.Lib.Models;

namespace TriangleCalc.Benchmark
{
    [SimpleJob(RuntimeMoniker.NativeAot80)]
    public class TriangleTypeBenchmark
    {
        private readonly ITriangleTypeDeterminer _typeDeterminer;

        public TriangleTypeBenchmark()
        {
            _typeDeterminer = new TriangleTypeDeterminer();
        }

        // Example triangles for benchmarking
        private readonly Triangle acuteTriangle = new Triangle(5, 6, 7);
        private readonly Triangle rightTriangle = new Triangle(3, 4, 5);
        private readonly Triangle obtuseTriangle = new Triangle(6, 8, 12);

        [Benchmark]
        public void BenchmarkRightTriangle()
        {
            _typeDeterminer.DetermineTriangleType(rightTriangle);
        }

        [Benchmark]
        public void BenchmarkAcuteTriangle()
        {
            _typeDeterminer.DetermineTriangleType(acuteTriangle);
        }

        [Benchmark]
        public void BenchmarkObtuseTriangle()
        {
            _typeDeterminer.DetermineTriangleType(obtuseTriangle);
        }
    }
}
