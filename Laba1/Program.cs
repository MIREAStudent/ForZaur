using System;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Building building = new Building();

            building.Appartment = 1000;
            building.Floor = 10;
            building.Porch = 5;
            building.Height = 30;

            Console.WriteLine(building.appartmentInPorch());
            Console.WriteLine(building.heightFloor());
            Console.WriteLine(building.appartmentInFloor());


            Console.ReadKey();




        }
    }
}
