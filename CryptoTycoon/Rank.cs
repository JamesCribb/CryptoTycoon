// Represents the player's progress through the ranks of drug dealing
namespace CryptoTycoon
{
    public class Rank
    {
        public int Id { get; }
        public string Name { get; }
        public int InventoryCapacity { get; }
        // Player must stay above cash threshold for X days in order to receive promotion
        // to next rank
        // TODO: Demotion?
        public int CashThreshold { get; }

        public Rank(int id, string name, int inventoryCapacity, int cashThreshold)
        {
            Id = id;
            Name = name;
            InventoryCapacity = inventoryCapacity;
            CashThreshold = cashThreshold;
        }
    }
}
