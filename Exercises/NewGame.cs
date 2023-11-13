using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class NewGame : IGameStrategy
    {
        private string name;
        public string Name
        {
            get 
            { 
                return name; 
            }
        }
        public NewGame()
        {

        }
        public NewGame(string name)
        {
            this.name = name;
        }
        public void Play()
        {
            if (name == null)
            {
                Console.WriteLine("Новая игра");
            }
            else
            {
                Console.WriteLine($"Игра в {name}\n");
            }
        }
    }
}
