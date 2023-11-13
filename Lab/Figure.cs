using System;

namespace Lab
{
    
    enum State
    {
        Видимое,
        Невидимое
    }
    enum Color
    {
        Красный,
        Синий,
        Зеленый
    }
    internal abstract class Figure : IMove, IChangeColor, IChangeState
    {
        protected Color color; 
        public Color Color
        { 
            get 
            { 
                return color; 
            } 
        }
        protected State state;
        public State State
        { 
            get 
            { 
                return state; 
            } 
        }
        public Figure(Color color, State state)
        {
            this.color = color;
            this.state = state;
        }

        public abstract Coordinates MoveVert(int distance);
        public abstract Coordinates MoveHoriz(int distance);
        public Color ChangeColor(Color new_color)
        {
            color = new_color;
            return color;
        }
        public State ChangeState(State new_state)
        {
            state = new_state;
            return state;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Цвет фигуры {color}, состояние {state} ");
        }
    }
}
