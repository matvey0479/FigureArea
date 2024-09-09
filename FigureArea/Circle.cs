using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Circle:Figure
    {
        public double Radius {  get; set; }
        public Circle(double radius)
        {
            IsValidCircle(radius);
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI*Math.Pow(Radius, 2);
        }

        public void IsValidCircle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be positive.");
            }
           
        }



    }
}
