using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class GameDecorator : IGameStrategy
    {
        private readonly BigRaceTeam team;
        private readonly IGameStrategy game;

        public GameDecorator(BigRaceTeam team, IGameStrategy game)
        {
            this.team = team;
            this.game = game;
        }

        public void Play()
        {
            team.PlayGame();

            Console.WriteLine("Новая игра:");
            game.Play();
        }
    }
}
