using System.Drawing;

namespace CryptoTycoon
{
    public abstract class Equipment
    {
        public string Name { get; set; }
        public string CapitalisedName { get; }
        public int Cost { get; set; }
        public Image Image { get; set; }
        public bool IsOwnedByPlayer { get; set; }

        public Equipment(string name, int cost, Image image)
        {
            Name = name;
            CapitalisedName = name.Substring(0, 1).ToUpper() + name.Substring(1);
            Cost = cost;
            Image = image;
            IsOwnedByPlayer = false;
        }

        public override string ToString()
        {
            return CapitalisedName;
        }
    }
}
