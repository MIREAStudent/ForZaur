using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Rectangle: Point
    {
         Point peak1;
         Point peak2;
         Point peak3;
         Point peak4;

        public Rectangle(double xCoord1, double yCoord1, double xCoord2, double yCoord2, double xCoord3, double yCoord3, double xCoord4, double yCoord4,bool condition) : base(xCoord1, yCoord1, condition)
        {
            peak1 = new Point(xCoord1, yCoord1,condition);
            peak2 = new Point(xCoord2, yCoord2, condition);
            peak3 = new Point(xCoord3, yCoord3, condition);
            peak4 = new Point(xCoord4, yCoord4, condition);
        }

        public double Area()
        {
            double a = peak1.x - peak2.x;
            double b = peak1.y - peak3.y;

            return a * b;                
        } 

    }
}
