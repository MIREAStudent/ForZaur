using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Figure
    {
        protected String color = "#fff"; 
        protected  bool condition;

        public virtual void MoveVertically(int y)
        {
            Console.WriteLine("Передвижение объекта");
        }

        public virtual void MoveHorizontally(int x)
        {
            Console.WriteLine("Передвижение объекта");
        }

        public virtual void SetColor(String color)
        {
            this.color = color;
        }
        public bool GetCondition()
        {
            return condition; 
        }

        public void Show()
        {
            Console.WriteLine(color);
            Console.WriteLine(condition);
        }

    }
}
