using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Triangle:Figure
    {
        public List<double> Sides;

        public Triangle(double side1, double side2, double side3)
        {
            IsValidTriangle(side1, side2, side3);
            Sides = new List<double>{side1,side2,side3 }
                .OrderBy(side=>side)
                .ToList();
        }

        public override double GetArea()
        {
            double area;
            if(IsRight())
            {
                area = (Sides[0]*Sides[1])/2;
            }
            else
            {
                var p = Sides.Sum() / 2;
                area = Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            }
            return area;
        }
        public bool IsRight()
        {
            return (Sides[0] * Sides[0] + Sides[1] * Sides[1] == Sides[2] * Sides[2]);
        }

        public void IsValidTriangle(double side1, double side2, double side3)
        {
            if(side1<=0||side2<=0||side3<=0)
            {
                throw new ArgumentException("All sides of a triangle must be positive.");
            }
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException("The given sides do not form a valid triangle.");
            }
        }
    }
}
