using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Building
    {
        private static int globalAccount = 1000;
        private int accoutn;
        private int height;
        private int floor;
        private int appartment;
        private int porch;

        public int Accoutn { get => accoutn; }
        public int Height { get => height; set => height = value; }
        public int Floor { get => floor; set => floor = value; }
        public int Appartment { get => appartment; set => appartment = value; }
        public int Porch { get => porch; set => porch = value; }

        public Building()
        {
            accoutn = globalAccount;
            globalAccount += 10;
        }

        public double heightFloor()
        {
            return (double)height / floor;
        }

        public int appartmentInPorch()
        {
            return appartment / porch;
        }

        public int appartmentInFloor()
        {
            return appartmentInPorch() / floor;
        }

    }
}
