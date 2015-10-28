using PokemonClass;

namespace VodachuClass
{
    class Vodachu : Pokemon
    {
        public Vodachu() : base()
        {
            damage = 1;
            name = "Водачу";
            unique_move = 3;
            armor = 6;
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
                Say(name + " вызывает мега-цунами!!! (-4xp)");
                enemy.health -= 4;
                return true;
            }
            return base.UniqueKick(ref enemy);
        }

    }
}
