using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Sea : IGameStrategy
    {
        public void Play()
        {
            Console.WriteLine("Игра в море");
        }
    }
}
