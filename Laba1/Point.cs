using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Point : Figure
    {
        protected int x;
        protected int y;

        public Point(int x, int y, bool condition)
        {
            this.x = x;
            this.y = y;
            this.condition = condition; 
        }

       public override void SetColor(String color)
        {
            this.color = color; 
        }
           
    }
}
