using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Rectangle : Point
    {
        private double wight, height;
        public double Width
        {
            get
            {
                return wight;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
        }
        public Rectangle(Color color, State state, Coordinates coordinates, double wight, double height) : base(color, state, coordinates)
        {
            this.wight = wight;
            this.height = height;
        }
        public double CalculateArea()
        {
            return wight * height;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Длина: {wight}, Высота: {height}, Площадь: {CalculateArea()}");
        }

    }

}
