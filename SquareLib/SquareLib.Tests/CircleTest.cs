using ShapeLib;

namespace ShapeLibUnitTests
{
    public class CircleTest
    {

        [Fact]
        public void TestCircleRadiusNegative()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void TestAreaCircleRadiusMax()
        {
            Shape shape = new Circle(double.MaxValue);
            Assert.Throws<ArgumentOutOfRangeException>(() => shape.GetArea());
        }

        [Fact]
        public void TestAreaCircleRadius5()
        {
            double radius = 5;
            double expected = Math.PI*radius*radius;
            Shape shape = new Circle(radius);
            double actual = shape.GetArea();
            Assert.Equal(expected, actual);
        }

    }
}