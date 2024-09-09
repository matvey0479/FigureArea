using System.Security.Principal;


namespace FigureArea.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        [TestCase(100,2,3)]
        [TestCase(-2, 2, 3)]
        public void ValidTriangle_Throws(double a,double b,double c)
        {
            Figure triangle;
            Assert.Throws<ArgumentException>(() => triangle = new Triangle(a,b,c));
        }

        [TestCase(5,4,3)]
        public void TriangleIsRight_True(double a,double b,double c)
        {
            var triangle = new Triangle(a,b,c);
            var exp = true;

            var isRight = triangle.IsRight();

            Assert.AreEqual(exp,isRight);


        }
        [TestCase(3,4,5,6)]
        [TestCase(10,8,6,24)]
        public void GetArea(double a,double b,double c, double expected)
        {
            var triangle = new Triangle(a,b,c);

            var area = triangle.GetArea();

            Assert.AreEqual(expected,area);
        }
        
        
    }
}
