using PokemonClass;

namespace PicachuClass
{
    class Picachu : Pokemon{
        public Picachu() : base() {
            damage = 2;
            name = "Пикачу";
            unique_move = 2;
            armor = 4;
        }
        public override void Move() {
            // may add something unique
            InSay(name + " "); base.Move();
        }
        public override void Kick(ref Pokemon enemy)
        {
            // may add something unique
            InSay(name + " "); base.Kick(ref enemy);
        }
        public override bool UniqueKick(ref Pokemon enemy) {
            if ((moves % unique_move) == 0)
            {
                Say(name+" нагоняет грозовую дичь на окружающих!!! (-3xp)");
                enemy.health -= 3;
                return true;
            }
            return base.UniqueKick(ref enemy);
        }

    }
}
