// The player's inventory is a list of InventoryDrugs.
// InventoryDrug holds information about the drug itself (name, id), as well as how many units of
// the drug the player has, and their average purchase price

namespace CryptoTycoon
{
    public class InventoryCoin
    {
        public Coin Coin { get; set; }
        public int Count { get; set; }
        public int AveragePrice { get; set; }

        public InventoryCoin(Coin coin)
        {
            Coin = coin;
            Count = 0;
        }

        // TODO: Would this be a good place to add error checking?
        public void Add(int quantity, int price)
        {
            // Update the average price
            AveragePrice = ((Count * AveragePrice) + (price * quantity)) / (Count + quantity);

            // Update the count
            Count += quantity;
        }

        public void Remove(int quantity)
        {
            Count -= quantity;
            // Don't update average price after selling
        }
    }
}
