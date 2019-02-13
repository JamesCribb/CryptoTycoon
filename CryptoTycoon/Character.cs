// Models the shared features of players and enemies used in fights
namespace CryptoTycoon
{
    public abstract class Character
    {
        public string Name { get; set; }
        public string CapitalisedName { get; set; }

        // TODO: Make all these attributes relevant
        public int Health { get; set; }
        public int CurrentHealth { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Mana { get; set; }

        public Weapon Weapon { get; set; }

        public Character(string name, int health, int attack, int defense, int speed, Weapon weapon)
        {
            Name = name;
            CapitalisedName = name.Substring(0, 1).ToUpper() + name.Substring(1);
            Health = health;
            CurrentHealth = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            Mana = 0;
            Weapon = weapon;
        }
    }
}
