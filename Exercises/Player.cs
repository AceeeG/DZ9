using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    enum Country
    {
        Россия,
        Франция,
        Китай,
        Казахстан
    }
    internal class Player : Person
    {
        private Country country;
        public Player(string name, Country country): base(name)
        { 
            this.country = country;
        }
        public override void Print() 
        {
            Console.WriteLine($"Страна: {country}, Имя: {name}");
        }
    }
}
