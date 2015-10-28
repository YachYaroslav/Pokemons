using PokemonClass;

namespace StalkchuClass
{
    class Stalkchu : Pokemon
    {
        public Stalkchu() : base()
        {
            damage = 2;
            name = "Сталкчу";
            unique_move = 4;
            armor = 3;
        }
        public override void Move()
        {
            // may add something unique
            InSay(name + " "); base.Move();
        }
        public override void Kick(ref Pokemon enemy)
        {
            // may add something unique
            InSay(name + " "); base.Kick(ref enemy);
        }
        public override bool UniqueKick(ref Pokemon enemy)
        {
            if ((moves % unique_move) == 0)
            {
                Say(name + " взрывает царь-бомбу!!! (-7xp)");
                enemy.health -= 6;
                return true;
            }
            return base.UniqueKick(ref enemy);
        }

    }
}
