using PokemonClass;

namespace OgonchuClass
{
    class Ogonchu : Pokemon
    {
        public Ogonchu() : base()
        {
            damage = 4;
            name = "Огончу";
            unique_move = 5;
            armor = 0;
        }
        public override void Move()
        {
            // may add something unique
            InSay(name + " "); base.Move();
        }
        public override void Kick(ref Pokemon enemy)
        {
            health--;
            InSay(name + " стал меньше( при атаке -1 xp ) "); base.Kick(ref enemy);
        }
        public override bool UniqueKick(ref Pokemon enemy)
        {
            if ((moves % unique_move) == 0)
            {
                Say(name + " делает чадный заслон из многочисленных пожаров!!! (-6xp)");
                enemy.health -= 6;
                return true;
            }
            return base.UniqueKick(ref enemy);
        }

    }
}
