using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Fishing : IGameStrategy
    {
        public void Play()
        {
            Console.WriteLine("Игра в рыбалку");
        }
    }
}
