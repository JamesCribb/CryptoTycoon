using System.Collections.Generic;
using System.Drawing;

namespace CryptoTycoon
{
    public class Location
    {
        public int Id { get; }
        public string Name { get; set; }
        public List<Coin> Coins { get; set; }
        public Image Image { get; set; }

        public Location(int id, string name, Image image)
        {
            Id = id;
            Name = name;
            Coins = new List<Coin>();
            Image = image;
        }

        // Given a drug id, return the location-specific instance of that drug.
        public Coin FindCoinById(int id)
        {
            foreach (Coin d in Coins)
            {
                if (d.Id == id)
                {
                    return d;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
