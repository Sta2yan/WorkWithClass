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

            player.ShowStats();
        }
    }

    public class Player
    {
        private string _nickname;
        private int _health;
        private int _level;

        public Player(string nickname, int health, int level)
        {
            _nickname = nickname;
            _health = health;
            _level = level;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Имя - {_nickname} | Жизней - {_health} | Уровень - {_level}");
        }
    }
}