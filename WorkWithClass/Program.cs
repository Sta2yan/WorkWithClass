using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerNickname = "Player_1";
            int health = 100;
            int level = 1;

            Player player = new Player(playerNickname, health, level);

            player.ShowStatsPlayer();
        }
    }

    public class Player
    {
        private string _nickname;
        private int _health;
        private int _level;

        public Player(string nickname, int health, int level)
        {
            this._nickname = nickname;
            this._health = health;
            this._level = level;
        }

        public void ShowStatsPlayer()
        {
            Console.WriteLine($"Имя - {_nickname} | Жизней - {_health} | Уровень - {_level}");
        }
    }
}