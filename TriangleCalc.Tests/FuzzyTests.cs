using Bogus;
using TriangleCalc.Lib;
using TriangleCalc.Lib.Interfaces;
using TriangleCalc.Lib.Models;

namespace TriangleCalc.Tests
{
    public class FuzzyTests
    {
        private readonly ITriangleTypeDeterminer _typeDeterminer;
        private readonly Faker _faker;

        public FuzzyTests()
        {
            _typeDeterminer = new TriangleTypeDeterminer();
            _faker = new Faker();
        }

        [Fact]
        public void FuzzyTestForTriangleType()
        {
            for (int i = 0; i < 1000; i++) // Number of random tests
            {
                // Generate random side lengths
                double a = _faker.Random.Double(0, 100);
                double b = _faker.Random.Double(0, 100);
                double c = _faker.Random.Double(0, 100);

                var triangle = new Triangle(a, b, c);

                // No exception should be thrown
                var ex = Record.Exception(() => _typeDeterminer.DetermineTriangleType(triangle));
                Assert.Null(ex);
            }
        }
    }
}
