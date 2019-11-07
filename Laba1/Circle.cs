using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Circle : Point
    {
        protected double radius; 
       


        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2); 
        }

        public override void MoveHorizontally(int x)
        {
            this.x += x;
        }
        public override void MoveVertically(int y)
        {
            this.y += y;
        }

    }
}
