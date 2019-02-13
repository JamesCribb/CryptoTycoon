using System.Collections.Generic;
using System.Drawing;

namespace CryptoTycoon
{
    public class Coin
    {
        public int Id { get; }
        public string Name { get; }
        public int Price { get; set; }
        public List<int> PastPrices { get; } // earliest price first
        public int MaxPrice { get; }
        public int MinPrice { get; }
        public int Variance { get; } // amount a coin can increase or decrease in value in a normal turn

        public bool RumourUp { get; set; }
        public bool RumourDown { get; set; }
        public bool RumourTrue { get; set; }

        public Image Icon { get; set; }

        public Coin(int id, string name, int startingPrice, Image icon)
        {
            Id = id;
            Name = name;
            Price = startingPrice;
            PastPrices = new List<int>();
            MaxPrice = startingPrice * 10;
            MinPrice = startingPrice / 10;
            Variance = startingPrice / 2;

            RumourUp = false;
            RumourDown = false;
            RumourTrue = false;

            Icon = icon;
        }
    }
}
