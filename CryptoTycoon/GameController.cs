// This class contains the fields and methods that make the game run.

/*
 * Possible future features:
 * - Limited number of coins to buy at each location
 * - Levelling system
 * - Fights
 */

using System;
using System.Collections.Generic;
using System.Drawing;

namespace CryptoTycoon
{
    public class GameController
    {
        private const int DaysLimit = 40;
        private const int RumourChance = 10;    // ie, a 1 in 10 chance
        private const int TrueRumourChance = 2; // given a rumour, the chance it will be true
        private const int MinRumourChange = 3;  // minimum true rumour multiplier
        private const int MaxRumourChange = 6;  // maximum true rumour multiplier

        public int Day { get; set; }
        public Player Player { get; set; }
        private List<Coin> coins;
        public List<Location> Locations { get; set; }
        private List<Message> messages;
        private List<Message> fightMessages;
        public List<Rank> Ranks { get; set; }
        private Random rand;

        // Fight stuff
        private const int FightChance = 4; // Original value = 5
        private const double HospitalTreatmentConstant = 1.1;
        public enum RoundResult { PlayerDead = 0, EnemyDead = 1, BothAlive = 2 };
        public bool IsFightHappening { get; set; }
        public Enemy Enemy { get; set; }
        public List<Enemy> Enemies { get; set; }
        private int healthRecoveredSoFar; // prevents load-scumming with hospital cost formula
        // Weapon / Defense stuff
        private Weapon fist, knife, machete, pistol, shotgun, assaultRifle, machineGun, rpg;
        public List<Weapon> Weapons { get; }
        public List<DefenseItem> DefenseItems { get; }

        public GameController()
        {
            Day = 0;
            rand = new Random();
            coins = new List<Coin>();
            Locations = new List<Location>();
            messages = new List<Message>();
            fightMessages = new List<Message>();
            Weapons = new List<Weapon>();
            DefenseItems = new List<DefenseItem>();
            Ranks = new List<Rank>();
            Enemies = new List<Enemy>();

            InitialiseDrugs();
            InitialiseLocations();
            InitialiseWeapons();
            InitialiseDefenseItems();
            InitialiseEnemies();
            InitialiseRanks();
            InitialisePlayer();
        }

        // Iterates through the game logic of a single day
        public bool RunDay()
        {
            if (Day >= DaysLimit)
            {
                return true;
            }
            else
            {
                messages.Clear();

                // TODO: Put the health recovery stuff in its own method?
                if (Player.CurrentHealth < Player.Health)
                {
                    Player.CurrentHealth += Player.HealthRecoveredPerDay;
                    if (Player.CurrentHealth > Player.Health)
                    {
                        Player.CurrentHealth = Player.Health;
                    }
                    messages.Add(new Message("You treat your wounds and recover a few points of health",
                        Color.DarkSalmon));
                }

                CheckForPromotion();
                SetPrices();
                SetRumours();
                SetFight();
                healthRecoveredSoFar = 0; // resets the hospital cost calculation
                Day++;
                return false;
            }
        }

        private void InitialiseDrugs()
        {
            int coinId = 0;

            Coin litecoin = new Coin(coinId++, "Litecoin", 350, Properties.Resources.litecoin);
            coins.Add(litecoin);
            Coin bitcoin = new Coin(coinId++, "Bitcoin", 250, Properties.Resources.bitcoin);
            coins.Add(bitcoin);
            Coin ethereum = new Coin(coinId++, "Ethereum", 100, Properties.Resources.ethereum);
            coins.Add(ethereum);
            Coin monero = new Coin(coinId++, "Monero", 150, Properties.Resources.monero);
            coins.Add(monero);
            Coin tether = new Coin(coinId++, "Tether", 110, Properties.Resources.tether);
            coins.Add(tether);
            Coin dogecoin = new Coin(coinId++, "Dogecoin", 50, Properties.Resources.dogecoin);
            coins.Add(dogecoin);
        }

        private void InitialiseLocations()
        {
            int locationId = 0;

            Location tokyo = new Location(locationId++, "Tokyo",
                Properties.Resources.tokyo);
            Locations.Add(tokyo);
            Location sydney = new Location(locationId++, "Sydney",
                Properties.Resources.sydney);
            Locations.Add(sydney);
            Location sanFrancisco = new Location(locationId++, "San Francisco",
                Properties.Resources.sanFrancisco);
            Locations.Add(sanFrancisco);
            Location london = new Location(locationId++, "London",
                Properties.Resources.london);
            Locations.Add(london);
            Location newYork = new Location(locationId++, "New York",
                Properties.Resources.newYork);
            Locations.Add(newYork);
            Location shanghai = new Location(locationId++, "Shanghai",
                Properties.Resources.shanghai);
            Locations.Add(shanghai);

            foreach (Location loc in Locations)
            {
                foreach (Coin c in coins)
                {
                    loc.Coins.Add(new Coin(c.Id, c.Name, c.Price, c.Icon));
                }
            }
        }

        // TODO: I think it makes sense to use concrete variables for weapons, rather than ids.
        // If not, change it later
        private void InitialiseWeapons()
        {
            // TODO: Increase prices, probably
            fist = new Weapon("fist", 0, Properties.Resources.fist, 10);
            Weapons.Add(fist);
            knife = new Weapon("knife", 50, Properties.Resources.knife, 20);
            Weapons.Add(knife);
            machete = new Weapon("machete", 250, Properties.Resources.machete, 30);
            Weapons.Add(machete);
            pistol = new Weapon("pistol", 1000, Properties.Resources.pistol, 50);
            Weapons.Add(pistol);
            shotgun = new Weapon("shotgun", 2500, Properties.Resources.shotgun, 70);
            Weapons.Add(shotgun);
            assaultRifle = new Weapon("assault rifle", 5000, Properties.Resources.assaultrifle, 100);
            Weapons.Add(assaultRifle);
            machineGun = new Weapon("machine gun", 25000, Properties.Resources.machine_gun, 130);
            Weapons.Add(machineGun);
            rpg = new Weapon("rpg", 100000, Properties.Resources.rpg, 200);
            Weapons.Add(rpg);
        }

        private void InitialiseDefenseItems()
        {
            DefenseItems.Add(new DefenseItem("glasses", 100, Properties.Resources.glasses, 1, 5));
            DefenseItems.Add(new DefenseItem("trench coat", 1000, Properties.Resources.trench_coat,
                1, 10));
            DefenseItems.Add(new DefenseItem("bulletproof vest", 15000, Properties.Resources.bp_vest,
                1, 15));
            DefenseItems.Add(new DefenseItem("kevlar helmet", 100000, Properties.Resources.helmet,
                1, 30));
            DefenseItems.Add(new DefenseItem("titanium exoskeleton", 1000000, Properties.Resources.exoskeleton,
                1, 50));
            DefenseItems.Add(new DefenseItem("medkit", 30000, Properties.Resources.medkit, 5));

        }

        private void InitialiseRanks()
        {
            int rankId = 0;
            Ranks.Add(new Rank(rankId++, "Impoverished trader", 10, 2500));
            Ranks.Add(new Rank(rankId++, "Small-time trader", 50, 10000));
            Ranks.Add(new Rank(rankId++, "Minor trader", 250, 50000));
            Ranks.Add(new Rank(rankId++, "Major trader", 1000, 250000));
            Ranks.Add(new Rank(rankId++, "Minor broker", 5000, 1000000));
            Ranks.Add(new Rank(rankId++, "Major broker", 50000, 10000000));
            Ranks.Add(new Rank(rankId++, "Renowned broker", 1000000, 1000000000));
            Ranks.Add(new Rank(rankId++, "Crypto Tycoon", int.MaxValue, -1));
        }

        private void InitialiseEnemies()
        {
            Enemies.Add(new Enemy("pickpocket", 50, 3, 1, 2, Properties.Resources.junkie, fist, 1));
            Enemies.Add(new Enemy("conman", 75, 2, 2, 1, Properties.Resources.stoner, fist, 1));
            Enemies.Add(new Enemy("mugger", 75, 5, 1, 5, Properties.Resources.methhead, knife, 2));
            Enemies.Add(new Enemy("enforcer", 125, 4, 3, 4, Properties.Resources.bogan, machete, 3));
            Enemies.Add(new Enemy("bikie", 175, 5, 5, 7, Properties.Resources.bikie, shotgun, 5));
            Enemies.Add(new Enemy("mafia", 200, 6, 6, 6, Properties.Resources.mobsters, assaultRifle, 6));
            Enemies.Add(new Enemy("triad", 250, 7, 7, 7, Properties.Resources.triad, machineGun, 7));
            Enemies.Add(new Enemy("paramilitary strike force", 300, 10, 9, 10, Properties.Resources.military_strike_force, rpg, 8));
        }

        private void InitialisePlayer()
        {
            Player = new Player("Fred Fredson", 1000, Locations[1], 150, 5, 5, 5, 5, fist,
                Ranks[0]); // start in Sydney
            coins.ForEach(d => Player.Inventory.Add(new InventoryCoin(d)));
        }

        private void SetPrices()
        {
            foreach (Location loc in Locations)
            {
                foreach (Coin c in loc.Coins)
                {
                    int rumourModifier = 0;
                    // If the coin has a rumour, determine whether the rumour is true
                    // If the rumour is true, the rumourModifier is set so that the price will rise
                    // or fall significantly
                    if (c.RumourUp || c.RumourDown)
                    {
                        if (rand.Next(TrueRumourChance) == 1)
                        {
                            if (c.RumourUp)
                            {
                                rumourModifier = c.Variance * rand.Next(MinRumourChange, MaxRumourChange);
                                messages.Add(new Message($"The rumour about {c.Name} in {loc.Name} was true! " +
                                    $"Prices are going to the moon!",
                                    Color.Green));
                            }
                            else
                            {
                                rumourModifier = -(c.Variance * rand.Next(MinRumourChange, MaxRumourChange));
                                messages.Add(new Message($"The rumour about {c.Name} in {loc.Name} was true! " +
                                    $"Prices are lower than the Mariana Trench!", Color.Green));
                            }
                        }
                        else
                        {
                            messages.Add(new Message($"The rumour about {c.Name} in {loc.Name} was false!", Color.Red));
                        }
                    }

                    // Normal price change formula that applies to all coins
                    int magnitude = rand.Next(c.Variance);
                    int change = ((rand.Next(2) == 1) ? magnitude : magnitude * -1) + rumourModifier;
                    c.PastPrices.Add(c.Price);
                    // Make sure the price doesn't fall below the minimum or above the maximum
                    if (c.Price + change > c.MaxPrice)
                    {
                        c.Price = c.MaxPrice;
                    }
                    else if (c.Price + change < c.MinPrice)
                    {
                        c.Price = c.MinPrice;
                    }
                    else
                    {
                        c.Price = c.Price + change;
                    }
                }
            }
        }

        private void SetRumours()
        {
            foreach (Location loc in Locations)
            {
                foreach (Coin c in loc.Coins)
                {
                    // Reset the rumour flags
                    c.RumourUp = false;
                    c.RumourDown = false;
                    // Determine if a rumour is generated
                    if (rand.Next(RumourChance) == 0)
                    {
                        // Determine which sort of rumour will be generated
                        if (rand.Next(2) == 1)
                        {
                            c.RumourUp = true;
                            messages.Add(new Message($"You hear a rumour that {c.Name} will be expensive" +
                                $" tomorrow in {loc.Name}."));
                        }
                        else
                        {
                            c.RumourDown = true;
                            messages.Add(new Message($"You hear a rumour that {c.Name} will be cheap tomorrow in {loc.Name}."));
                        }
                    }
                }
            }
        }

        public List<Message> GetMessages()
        {
            return messages;
        }

        public List<Message> GetFightMessages()
        {
            return fightMessages;
        }

        // Generates a list of strings representing relevant drug info, to be retrieved by the form
        public List<CoinListItem> GetCoinInfo()
        {
            // Determine the city-wide average prices
            // TODO: When coins don't exist in some locations, average needs to be refined...
            int[] averagePrices = new int[coins.Count];
            foreach (Location loc in Locations)
            {
                foreach (Coin c in loc.Coins)
                {
                    averagePrices[c.Id] += c.Price;
                }
            }
            for (int i = 0; i < averagePrices.Length; i++)
            {
                averagePrices[i] /= Locations.Count;
            }

            List<CoinListItem> coinIfo = new List<CoinListItem>();

            foreach (Coin c in Player.CurrentLocation.Coins)
            {
                // Determine the price change
                string priceChange = "";
                if (Day > 1)
                {
                    int difference = c.Price - c.PastPrices[c.PastPrices.Count - 1];
                    priceChange = difference > 0 ? "+" : "";
                    priceChange += difference;
                }

                // TODO: Average price should not be dependent on index position
                coinIfo.Add(new CoinListItem(c, averagePrices[c.Id],
                    Player.FindInventoryCoinById(c.Id).Count, Day));
            }

            return coinIfo;
        }

        // Given a coin, returns the MINIMUM of the following two values:
        // - The number of units the player can afford
        // - The number of units the player can fit in their inventory
        public int GetMaxCoinsToBuy(int id)
        {
            int maximumUnitsAffordable = 0;
            foreach (Coin c in Player.CurrentLocation.Coins)
            {
                if (c.Id == id)
                {
                    maximumUnitsAffordable = (int)Player.Funds / c.Price;
                }
            }

            int maxSpaceAvailable = Player.MaxInventorySize - Player.GetNumCoinsInInventory();

            return Math.Min(maximumUnitsAffordable, maxSpaceAvailable);
        }

        // Returns the number of drugs with the given id the player has in their inventory
        public int GetMaxCoinsToSell(int id)
        {
            foreach (InventoryCoin iCoin in Player.Inventory)
            {
                if (iCoin.Coin.Id == id)
                {
                    return iCoin.Count;
                }
            }
            return -1;
        }

        // Returns the average profit (per unit) based on the average price of the inventory drug,
        // and the sell price in the current location
        public int GetAverageProfit(int coinId)
        {
            int averagePrice = Player.FindInventoryCoinById(coinId).AveragePrice;
            int sellPrice = Player.CurrentLocation.FindCoinById(coinId).Price;
            return sellPrice - averagePrice;
        }

        public void BuyCoins(int coinId, int quantity)
        {
            Coin coinToBuy = Player.CurrentLocation.FindCoinById(coinId);
            int cost = coinToBuy.Price * quantity;
            Player.FindInventoryCoinById(coinId).Add(quantity, coinToBuy.Price);
            Player.Funds -= cost;
            messages.Add(new Message($"Bought {quantity} units of {coinToBuy.Name} for ${cost}", Color.Blue));
        }

        public void SellCoins(int coinId, int quantity)
        {
            Coin coinToSell = Player.CurrentLocation.FindCoinById(coinId);
            double income = coinToSell.Price * quantity;
            Player.FindInventoryCoinById(coinId).Remove(quantity);
            Player.Funds += income;
            messages.Add(new Message($"Sold {quantity} units of {coinToSell.Name} for ${income}", Color.Blue));
        }

        public void Travel(Location location)
        {
            Player.CurrentLocation = location;
        }

        // Determines whether a fight will take place this day.
        // If true, sets the initial fight parameters
        private void SetFight()
        {
            IsFightHappening = false;
            fightMessages.Clear();

            if (rand.Next(FightChance) == 0)
            {
                IsFightHappening = true;
                if (Enemy != null)
                {
                    Enemy.CurrentHealth = Enemy.Health;
                }
                // Choose the enemy from a range adjacent to the player's rank
                Enemy = null;
                int targetLevel = Player.Rank.Id;
                while (Enemy == null)
                {
                    Enemy potentialEnemy = Enemies[rand.Next(Enemies.Count)];
                    if (Math.Abs(potentialEnemy.Level - Player.Rank.Id) <= 1)
                    {
                        Enemy = potentialEnemy;
                    }
                }

                fightMessages.Add(new Message($"A {Enemy.Name} wants to fight!", Color.Black));
            }
        }

        // Resolves a turn of fighting
        public int FightTurn()
        {
            Attack(Player, Enemy);
            if (Enemy.CurrentHealth <= 0)
            {
                Enemy.CurrentHealth = 0;
                fightMessages.Add(new Message($"The {Enemy.Name} decides to flee!"));
                // Average cash reward increases quadratically based on enemy level
                int bonusCash = rand.Next(1, 101) * Enemy.Level * Enemy.Level;
                Player.Funds += bonusCash;
                messages.Add(new Message($"The {Enemy.Name} drops ${bonusCash} as he flees!",
                    Color.DarkCyan));
                return (int)RoundResult.EnemyDead;
            }
            Attack(Enemy, Player);
            if (Player.CurrentHealth <= 0)
            {
                Player.CurrentHealth = 0;
                fightMessages.Add(new Message($"You have been defeated by a {Enemy.Name}!"));
                return (int)RoundResult.PlayerDead;
            }
            return (int)RoundResult.BothAlive;
        }

        // One character attacks another
        private void Attack(Character attacker, Character defender)
        {
            // TODO: Remove test messages once system is working properly

            float attackModifier = ((float)rand.Next(attacker.Attack - 1, attacker.Attack + 2)) / 10;
            fightMessages.Add(new Message($"attackModifier: {attackModifier}", Color.DarkGreen));

            float rawAttack = attacker.Weapon.DamageRating * attackModifier;
            fightMessages.Add(new Message($"raw attack: {rawAttack}", Color.DarkGreen));

            float defenseModifier = (float)rand.Next(defender.Defense - 1, defender.Defense + 2) / 10;
            defenseModifier = defenseModifier > 0.9f ? 0.9f : defenseModifier;
            fightMessages.Add(new Message($"defenseModifider: {defenseModifier}", Color.DarkGreen));

            int damage = (int)(rawAttack * (1 - defenseModifier));
            fightMessages.Add(new Message($"damage: {damage}", Color.DarkGreen));
            damage = damage == 0 ? 1 : damage;

            defender.CurrentHealth -= damage;
            fightMessages.Add(new Message($"{attacker.CapitalisedName} strikes for {damage} points of damage " +
                $"using {attacker.Weapon.Name}!",
                attacker is Player ? Color.Blue : Color.Red));
        }

        // Player's flee chance = speed / 10.
        // TODO: Make this dependent on enemy's speed too?
        // TODO: Buy Vehicles to boost speed?
        public bool TryToFlee()
        {
            int result = rand.Next(10);
            if (result == 0)
            {
                messages.Add(new Message("You manage to flee from the fight.", Color.Black));
                return true;
            }
            else if (result < Player.Speed)
            {
                messages.Add(new Message("You manage to flee from the fight.", Color.Black));
                return true;
            }
            else
            {
                return false;
            }
        }

        // Cost is reset after each turn
        public int CalculateHospitalCost(int healthToRecover)
        {
            double totalCost = 0;
            for (int i = 1; i <= healthToRecover; i++)
            {
                totalCost += Math.Pow(HospitalTreatmentConstant, healthRecoveredSoFar + i);
            }

            return (int)totalCost;
        }

        public void RecoverHealthHospital(int healthToRecover)
        {
            Player.Funds -= CalculateHospitalCost(healthToRecover);
            Player.CurrentHealth += healthToRecover;
            healthRecoveredSoFar += healthToRecover;
        }

        // TODO: Add case for defensive stuff
        public void BuyEquipment(Equipment e)
        {
            if (e is Weapon weapon)
            {
                Player.Weapon = weapon;
                Player.AvailableWeapons.Add(weapon);
                Player.AvailableWeapons.Sort();
            }
            // TODO: Give the player a list of defenseItems?
            else if (e is DefenseItem defenseItem)
            {
                defenseItem.IsOwnedByPlayer = true;
                Player.Defense += defenseItem.DefenseBonus;
                Player.Health += defenseItem.HealthBonus;
                Player.CurrentHealth += defenseItem.HealthBonus;
                Player.HealthRecoveredPerDay += defenseItem.HealthRecoveryBonus;
            }
            Player.Funds -= e.Cost;
            messages.Add(new Message($"Bought a {e.CapitalisedName} for ${e.Cost}"));
        }

        public void SwapWeapon(Weapon weapon)
        {
            foreach (Weapon w in Player.AvailableWeapons)
            {
                if (w == weapon)
                {
                    Player.Weapon = weapon;
                    return;
                }
            }
        }

        public bool AlreadyHasWeapon(Weapon weapon)
        {
            foreach (Weapon w in Player.AvailableWeapons)
            {
                if (w == weapon)
                {
                    return true;
                }
            }
            return false;
        }

        // TODO: Player must meet cash threshold for multiple consecutive days?
        private void CheckForPromotion()
        {
            if (Player.Funds >= Player.Rank.CashThreshold &&
                Player.Rank.Id != Ranks.Count - 1)
            {
                Player.Rank = Ranks[Player.Rank.Id + 1];
                Player.MaxInventorySize = Player.Rank.InventoryCapacity;
                messages.Add(new Message($"You have been promoted to {Player.Rank.Name.ToUpper()}!",
                    Color.DarkOrange));
                if (Player.Rank.Id != Ranks.Count - 1)
                {
                    messages.Add(new Message($"To advance to the next rank, end a day with at least " +
                        $"{Player.Rank.CashThreshold:C} in your funds."));
                }

            }
        }
    }
}
