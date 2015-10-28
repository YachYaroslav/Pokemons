using System;
using StartGame;

namespace Pokemons
{
    public class Program
    {
        static void Main(string[] args){
            Game game = new Game();
            game.GetTypeOfHeroes();
            Game.Player winner = game.Play();
            Console.Clear();
            Console.WriteLine("\n\n\n\tПоздровляем! {0} / {1} - победитель!\n\n\n",winner.name,winner.hero.name);
            Console.ReadKey();
        }
    }
}
