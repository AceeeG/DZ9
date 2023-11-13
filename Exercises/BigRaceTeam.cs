using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class BigRaceTeam
    {
        private List<Player> players;
        public List<Player> Players
        { 
            get 
            { 
                return players; 
            } 
        }
        private List<IGameStrategy> strategies;
        public List<IGameStrategy> Strategies
        {
            get
            {
                return strategies;
            }
        }
        public BigRaceTeam()
        {

        }
        public BigRaceTeam(List<Player> players)
        {
            this.players = players;
        }
        public BigRaceTeam(List<Player> players,List<IGameStrategy> strategies)
        {
            this.players = players;
            this.strategies = strategies;
        }
        public void AddGame(IGameStrategy game)
        {
            strategies.Add(game);
        }

        public void PlayGame()
        {
            foreach (var game in strategies)
            {
                game.Play();
            }
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
    }
}
