using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea.Tests
{
    [TestFixture]
    public class CircleTest
    {
        [TestCase(0)]
        [TestCase(-2)]
        public void ValidCircle_Throw(double radius)
        {
            Figure circle;
            Assert.Throws<ArgumentException>(() => circle = new Circle(radius));
        }

        [TestCase(2.6, 21.237166338267002)]
        public void GetArea(double radius, double expected)
        {
            var circle = new Circle(radius);

            var area = circle.GetArea();

            Assert.AreEqual(expected, area);
        }
    }
}
