using System.Drawing;

// Defensive items increase the player's defense rating and health
// The medkit increases the amount of health regenerated per day.
// Their effects are cumulative.
namespace CryptoTycoon
{
    public class DefenseItem : Equipment
    {
        public int DefenseBonus { get; }
        public int HealthBonus { get; }
        public int HealthRecoveryBonus { get; }
        public string Description { get; }

        // Constructor for normal defense items
        public DefenseItem(string name, int cost, Image image, int defenseBonus, int healthBonus)
            : base(name, cost, image)
        {
            DefenseBonus = defenseBonus;
            HealthBonus = healthBonus;
            HealthRecoveryBonus = 0;
            Description = $"+{DefenseBonus} Defense   +{HealthBonus} Health.";
        }

        // Constructor for medkit
        public DefenseItem(string name, int cost, Image image, int healthRecoveryBonus)
            : base(name, cost, image)
        {
            DefenseBonus = 0;
            HealthBonus = 0;
            HealthRecoveryBonus = healthRecoveryBonus;
            Description = "Increases the rate of health regeneration each day.";
        }
    }
}
