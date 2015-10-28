using System;

namespace PokemonClass
{
    public class Pokemon{
        public Pokemon() {
            _health = 10;
            moves = 0;
            die = false;
            armor = 5;
        }
        public void InSay(string message)
        {
            Console.Write(message);
        }
        public void Say(string message) {
            Console.WriteLine(message);
        }
        private int _health;
        public int health {
            get { return _health; }
            set
            {
                if (value <= 0) die = true;
                else _health = value;
            }
        }
        public virtual void Move() {
            Say("передвигается! И востонавливает силы...");
            if(health <= 10) health++;
            moves++;
        }
        public virtual void Kick(ref Pokemon enemy) {
            if (enemy.armor > 0)
            {
                Say("бьет по защите врага " + enemy.name + "!");
                enemy.armor -= damage;
                if (enemy.armor < 0) enemy.health += enemy.armor;
            }
            else
            {
                Say("бьет по врагу " + enemy.name + "!");
                enemy.health -= damage;
            }
        }
        public virtual bool UniqueKick(ref Pokemon enemy) {
            Say("У тебя не хватает ходов до востановления мощи... " + name + " убегает (-1 xp)!");
            if (armor > 0) armor--;
            else health--;
            return false;
        }
        public override string ToString()
        {
          if(!die) return string.Format("{0}, здоровье {1}, броня {2}, дамаг {3},\n супер-удар после каждого {4}-а шага, шаг номер {5}\n",name,health,armor,damage, unique_move, moves);
            return "мёртв!!!";
        }
        public int unique_move;
        public int moves;
        public int damage;
        public int armor;
        public string name { get; set; }
        public bool die;
    }
}
