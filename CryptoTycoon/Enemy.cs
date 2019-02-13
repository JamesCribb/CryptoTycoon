using System.Drawing;

namespace CryptoTycoon
{
    public class Enemy : Character
    {
        // Enemies have a level corresponding to their toughness
        // The higher the player's rank, the higher level the enemies
        public int Level { get; }
        public Image Image { get; }

        public Enemy(string name, int health, int attack, int defense, int speed, Image image,
            Weapon weapon, int level)
            : base(name, health, attack, defense, speed, weapon)
        {
            Image = image;
            Level = level;
        }
    }
}
