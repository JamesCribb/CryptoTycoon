using System;
using System.Drawing;

// Weapons are use by the player and enemies to inflict damage on each other.
// The default weapon is fist.
// A weapon's damage is modified by the wielder's attack level
namespace CryptoTycoon
{
    public class Weapon : Equipment, IComparable<Weapon>
    {
        public int DamageRating { get; set; }

        public Weapon(string name, int cost, Image image, int damageRating)
            : base(name, cost, image)
        {
            DamageRating = damageRating;
        }

        //Allows weapons to be sorted in ascending order of lethality
        public int CompareTo(Weapon w)
        {
            return DamageRating.CompareTo(w.DamageRating);
        }
    }
}
