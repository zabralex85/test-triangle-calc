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

        // Example triangles for benchmarking
        private readonly Triangle _invalidTriangle = new Triangle(0, 6, 7);
        private readonly Triangle _acuteTriangle = new Triangle(5, 6, 7);
        private readonly Triangle _rightTriangle = new Triangle(3, 4, 5);
        private readonly Triangle _obtuseTriangle = new Triangle(6, 8, 12);

        public TriangleTypeBenchmark()
        {
            _typeDeterminer = new TriangleTypeDeterminer();
        }
        
        [Benchmark]
        public void BenchmarkInvalidTriangle()
        {
            _typeDeterminer.DetermineTriangleType(_invalidTriangle);
        }

        [Benchmark]
        public void BenchmarkRightTriangle()
        {
            _typeDeterminer.DetermineTriangleType(_rightTriangle);
        }

        [Benchmark]
        public void BenchmarkAcuteTriangle()
        {
            _typeDeterminer.DetermineTriangleType(_acuteTriangle);
        }

        [Benchmark]
        public void BenchmarkObtuseTriangle()
        {
            _typeDeterminer.DetermineTriangleType(_obtuseTriangle);
        }
    }
}
