using System;

namespace Lab
{
    struct Coordinates
    {
        private int x;
        private int y;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
    internal class Point : Figure
    {
        protected Coordinates coordinates;
        public Coordinates Coordinates 
        { 
            get 
            { 
                return coordinates; 
            } 
        }
        public Point(Color color, State state, Coordinates coordinates) : base(color, state)
        {
            this.coordinates = coordinates;
        }
        public override Coordinates MoveVert(int distance)
        {
            coordinates.Y += distance;
            return coordinates;
        }
        public override Coordinates MoveHoriz(int distance)
        {
            coordinates.X += distance;
            return coordinates;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Координаты: ({coordinates.X}, {coordinates.Y}) ");
        }

    }
}
