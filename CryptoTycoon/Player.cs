using System.Collections.Generic;

namespace CryptoTycoon
{
    public class Player : Character
    {
        public double Funds { get; set; }
        public List<double> PastFunds { get; set; } // used to check if cash thresholds are met
        public List<InventoryCoin> Inventory { get; set; }
        public int MaxInventorySize { get; set; }
        public Rank Rank { get; set; }
        public Location CurrentLocation { get; set; }
        public int HealthRecoveredPerDay { get; set; }
        public List<Weapon> AvailableWeapons { get; set; }

        public Player(string name, int startingFunds, Location startingLocation, int health, int attack,
            int defense, int speed, int healthRecoveredPerDay, Weapon weapon, Rank rank)
            : base(name, health, attack, defense, speed, weapon)
        {
            Name = name;
            Funds = startingFunds;
            Inventory = new List<InventoryCoin>();
            CurrentLocation = startingLocation;
            HealthRecoveredPerDay = healthRecoveredPerDay;
            AvailableWeapons = new List<Weapon>();
            AvailableWeapons.Add(weapon);

            Rank = rank;
            MaxInventorySize = Rank.InventoryCapacity;
        }

        // Given a coin id, find the player-specific version of that coin
        public InventoryCoin FindInventoryCoinById(int id)
        {
            foreach (InventoryCoin iCoin in Inventory)
            {
                if (iCoin.Coin.Id == id)
                {
                    return iCoin;
                }
            }
            return null;
        }

        // Return the number of units currently in the inventory
        public int GetNumCoinsInInventory()
        {
            int totalUnits = 0;
            foreach (InventoryCoin idrug in Inventory)
            {
                totalUnits += idrug.Count;
            }
            return totalUnits;
        }
    }
}
