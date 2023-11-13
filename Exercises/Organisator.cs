using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Organisator : Person
    {
        public Organisator(string name) : base(name)
        {

        }
        public override void Print()
        {
            Console.WriteLine($"Организтор: {name}");
        }
    }
}
