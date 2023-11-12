using ShapeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibUnitTests
{
    public class TriangleTest
    {
        [Fact]
        public void TestAreaTriangleAMaxBMaxCMax()
        {
            Shape shape = new Triangle(double.MaxValue, double.MaxValue, double.MaxValue);
            Assert.Throws<ArgumentOutOfRangeException>(() => shape.GetArea());
        }

        [Fact]
        public void TestTriangleA1B1C10()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 1, 10));
        }

        [Fact]
        public void TestTriangleA1B1CNegative()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, -1));
        }

        [Fact]
        public void TestAreaTriangleIsRectangular()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);
            Assert.True(triangle.IsRectangular());
        }
        [Fact]
        public void TestAreaTriangleA3B4C5()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            Shape shape = new Triangle(a, b, c);
            double actual = shape.GetArea();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAreaTriangleA67B33C38()
        {
            double a = 67;
            double b = 33;
            double c = 38;
            double p = (a + b + c) / 2;
            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Shape shape = new Triangle(a, b, c);
            double actual = shape.GetArea();
            Assert.Equal(expected, actual);
        }
    }
}
