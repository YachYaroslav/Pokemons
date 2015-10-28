using System;
using System.Collections.Generic;
using PokemonClass;
using PicachuClass;
using VodachuClass;
using StalkchuClass;
using UragchuClass;
using OgonchuClass;

namespace StartGame
{
    public class Game
    {
        public class Player
        {
            public ushort player_switch;
            public Pokemon hero;
            public string name;
            public void RSwitch() {
                player_switch = Convert.ToUInt16(Console.ReadLine());
            }
        }
        public List<Player> players;
        public void GetTypeOfHeroes()
        {
            ushort kol;
            Console.WriteLine("\t\t" + "Игра \"Покемоны\" (by Yaroslav Yachmenov 'beta ver.')" + "\n");
            Console.WriteLine("\t1 - Пикачу; 2 - Водачу; 3 - Сталкчу; 4 - Урагчу; 5 - Огончу;\n\n");
            Console.Write("Введите количество игроков: ");
            kol = Convert.ToUInt16(Console.ReadLine());
            players = new List<Player>();
            for (var i = 1; i <= kol; i++)
            {
                Player temp = new Player();
                temp.name = String.Format("Игрок{0}", i);
                Console.Write("{0}, выберите тип покемона: ", temp.name);
                temp.RSwitch();
                switch (temp.player_switch)
                {
                    case 1:
                        temp.hero = new Picachu();
                        break;
                    case 2:
                        temp.hero = new Vodachu();
                        break;
                    case 3:
                        temp.hero = new Stalkchu();
                        break;
                    case 4:
                        temp.hero = new Uragchu();
                        break;
                    case 5:
                        temp.hero = new Ogonchu();
                        break;
                    default:
                        temp.hero = new Picachu();
                        break;
                }
                players.Add(temp);
            }
        }
        private void ClearUsers()
        {
            while (true)
            {
                bool yes = false;
                for(var i = 0; i < players.Count; i++)
                {
                    if (players[i].hero.die) { players.RemoveAt(i); break; }
                    if (i == players.Count - 1) yes = true;
                }
                if (yes) break;
            }
        }
        public Player Play()
        {
            while (players.Count > 1)
            {
                for (var i = 0; i < players.Count; i++)
                {
                    Console.Clear();
                    InfoUsers();
                    Console.WriteLine("\n\t1 - Пойти далее; 2 - Стукнуть всех; 3 - Супер-способность!;\n\n");
                    Console.Write("{0} / {1}, выберите действие: ", players[i].name, players[i].hero.name);
                    players[i].RSwitch();
                    switch (players[i].player_switch) {
                        case 1:
                            players[i].hero.Move();
                            break;
                        case 2:
                            for (var j = 0; j < players.Count; j++)
                                if(j != i) players[i].hero.Kick(ref players[j].hero);
                            break;
                        case 3:
                            bool yes;
                            for (var j = 0; j < players.Count; j++)
                            {
                                if (j != i)
                                {
                                   yes = players[i].hero.UniqueKick(ref players[j].hero);
                                    if (!yes) break;
                                }
                            }
                            break;
                    }
                    ClearUsers();
                    Console.ReadKey();
                }
            }
            return players[0];
        }
        private void InfoUsers()
        {
            for (var i = 0; i < players.Count; i++)
                Console.WriteLine("Игрок{0}: {1}", i + 1, players[i].hero.ToString());
        }
    }
}
