using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IGameStrategy> ru_strategies = new List<IGameStrategy>();
            List<Player> rus = new List<Player>();
            Organisator org = new Organisator("Оливье Ганьян");
            Player ru_player1 = new Player("Саша", Country.Россия);
            rus.Add(ru_player1);
            Player ru_player2 = new Player("Паша", Country.Россия);
            rus.Add(ru_player2);
            Player ru_player3 = new Player("Кристина", Country.Россия);
            rus.Add(ru_player3);
            Player ru_player4 = new Player("Даша", Country.Россия);
            rus.Add(ru_player4);
            Player ru_player5 = new Player("Сергей", Country.Россия);
            rus.Add(ru_player5);
            Player ru_player6 = new Player("кып", Country.Россия);
            rus.Add(ru_player6);
            Player ru_player7 = new Player("Саша", Country.Россия);
            rus.Add(ru_player7);
            Player ru_player8 = new Player("Саша", Country.Россия);
            rus.Add(ru_player8);
            Player ru_player9 = new Player("Саша", Country.Россия);
            rus.Add(ru_player9);
            Player ru_player10 = new Player("Саша", Country.Россия);
            rus.Add(ru_player10);
            Player ru_player11 = new Player("Саша", Country.Россия);
            rus.Add(ru_player11);
            Player ru_player12 = new Player("Саша", Country.Россия);          
            Player ru_player13 = new Player("Саша", Country.Россия);
            rus.Add(ru_player13);
            Player ru_player14 = new Player("Саша", Country.Россия);
            rus.Add(ru_player14);
            Player ru_player15 = new Player("Саша", Country.Россия);
            rus.Add(ru_player15);
            ru_strategies.Add(new Beach());
            ru_strategies.Add(new MouseTrap());
            ru_strategies.Add(new Sea());
            ru_strategies.Add(new Fishing());
            ru_strategies.Add(new Postmans());
            ru_strategies.Add(new Hill());
            BigRaceTeam team_rus = new BigRaceTeam(rus, ru_strategies);

            List<Player> frn = new List<Player>();
            List<IGameStrategy> frn_strategies = new List<IGameStrategy>();
            Player frc_player1 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player1);
            Player frc_player2 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player2);
            Player frc_player3 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player2);
            Player frc_player4 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player3);
            Player frc_player5 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player4);
            Player frc_player6 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player5);
            Player frc_player7 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player7);
            Player frc_player8 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player8);
            Player frc_player9 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player9);
            Player frc_player10 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player10);
            Player frc_player11 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player11);
            Player frc_player12 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player12);
            Player frc_player13 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player13);
            Player frc_player14 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player14);
            Player frc_player15 = new Player("Жоас", Country.Франция);
            frn.Add(frc_player15);
            frn_strategies.Add(new Beach());
            frn_strategies.Add(new MouseTrap());
            frn_strategies.Add(new Sea());
            frn_strategies.Add(new Fishing());
            frn_strategies.Add(new Postmans());
            frn_strategies.Add(new Hill());
            BigRaceTeam team_france = new BigRaceTeam(frn, frn_strategies);

            List<Player> chin = new List<Player>();
            List<IGameStrategy> china_strategies = new List<IGameStrategy>();
            Player chn_player1 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player1);
            Player chn_player2 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player2);
            Player chn_player3 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player3);
            Player chn_player4 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player4);
            Player chn_player5 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player5);
            Player chn_player6 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player6);
            Player chn_player7 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player7);
            Player chn_player8 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player8);
            Player chn_player9 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player9);
            Player chn_player10 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player10);
            Player chn_player11 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player11);
            Player chn_player12 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player12);
            Player chn_player13 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player13);
            Player chn_player14 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player14);
            Player chn_player15 = new Player("Тайлунг", Country.Китай);
            chin.Add(chn_player15);

            china_strategies.Add(new Beach());
            china_strategies.Add(new MouseTrap());
            china_strategies.Add(new Sea());
            china_strategies.Add(new Fishing());
            china_strategies.Add(new Postmans());
            china_strategies.Add(new Hill());

            BigRaceTeam team_china = new BigRaceTeam(chin, china_strategies);


            List<Player> kzh = new List<Player>();
            List<IGameStrategy> kzh_strategies = new List<IGameStrategy>();
            Player kzh_player1 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player1);
            Player kzh_player2 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player2);
            Player kzh_player3 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player3);
            Player kzh_player4 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player4);
            Player kzh_player5 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player5);
            Player kzh_player6 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player6);
            Player kzh_player7 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player7);
            Player kzh_player8 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player8);
            Player kzh_player9 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player9);
            Player kzh_player10 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player10);
            Player kzh_player11 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player11);
            Player kzh_player12 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player12);
            Player kzh_player13 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player13);
            Player kzh_player14 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player14);
            Player kzh_player15 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player15);

            kzh_strategies.Add(new Beach());
            kzh_strategies.Add(new MouseTrap());
            kzh_strategies.Add(new Sea());
            kzh_strategies.Add(new Fishing());
            kzh_strategies.Add(new Postmans());
            kzh_strategies.Add(new Hill());

            BigRaceTeam team_kazah = new BigRaceTeam(kzh, kzh_strategies);

            Console.WriteLine("Игры для команды Россия\n");
            team_rus.PlayGame();


            IGameStrategy my_game = new GameDecorator(team_france, new NewGame("Баскет"));
            Console.WriteLine("Игры для команды Франция\n");
            my_game.Play();

            Console.WriteLine("Игры для Китая\n");
            team_china.PlayGame();

            Console.WriteLine("Игры для Казахстана\n");
            team_kazah.PlayGame();


            Console.ReadKey();
        }
    }
}
