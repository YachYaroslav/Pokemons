using PokemonClass;

namespace UragchuClass
{
    class Uragchu : Pokemon
    {
        public Uragchu() : base()
        {
            damage = 2;
            name = "Урагчу";
            unique_move = 2;
            armor = 7;
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
                Say(name + " делает ураган со смерчем!!! (-3xp)");
                enemy.health -= 3;
                return true;
            }
            return base.UniqueKick(ref enemy);
        }

    }
}
