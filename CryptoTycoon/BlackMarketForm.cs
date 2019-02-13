using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoTycoon
{
    public partial class BlackMarketForm : Form
    {
        public Equipment SelectedItem { get; set; }
        private GameController gc;

        public BlackMarketForm(GameController gc)
        {
            InitializeComponent();
            descriptionLabel.Hide();
            buyButton.Enabled = false;
            this.gc = gc;
            List<Weapon> weapons = gc.Weapons;
            List<DefenseItem> defenseItems = gc.DefenseItems;
            weapons.ForEach(w => offensiveItemsComboBox.Items.Add(w));
            defenseItems.ForEach(d => defensiveItemsComboBox.Items.Add(d));
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            gc.BuyEquipment(SelectedItem);
            buyButton.Enabled = false;
            costLabel.Text = $"Cost: You already own this weapon.";
        }

        private void offensiveItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            descriptionLabel.Hide();

            SelectedItem = (Equipment)offensiveItemsComboBox.SelectedItem;
            itemPictureBox.Image = SelectedItem.Image;
            itemNameLabel.Text = $"Item: {SelectedItem.ToString()}";
            costLabel.Text = $"Cost: {SelectedItem.Cost:C}";
            if (gc.AlreadyHasWeapon((Weapon)SelectedItem))
            {
                costLabel.ForeColor = Color.Black;
                buyButton.Enabled = false;
                costLabel.Text = $"Cost: You already own this weapon.";
            }
            else
            {
                if (SelectedItem.Cost > gc.Player.Funds)
                {
                    costLabel.ForeColor = Color.Red;
                    buyButton.Enabled = false;
                }
                else
                {
                    costLabel.ForeColor = Color.Black;
                    buyButton.Enabled = true;
                }
            }
        }

        private void defensiveItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = (DefenseItem)defensiveItemsComboBox.SelectedItem;

            // TODO: Kinda dodgy...
            DefenseItem di = (DefenseItem)SelectedItem;
            descriptionLabel.Text = di.Description;
            descriptionLabel.Show();

            itemPictureBox.Image = SelectedItem.Image;
            itemNameLabel.Text = $"Item: {SelectedItem.ToString()}";
            costLabel.Text = $"Cost: {SelectedItem.Cost:C}";
            if (SelectedItem.IsOwnedByPlayer)
            {
                costLabel.ForeColor = Color.Black;
                buyButton.Enabled = false;
                costLabel.Text = $"Cost: You already own this item.";
            }
            else
            {
                if (SelectedItem.Cost > gc.Player.Funds)
                {
                    costLabel.ForeColor = Color.Red;
                    buyButton.Enabled = false;
                }
                else
                {
                    costLabel.ForeColor = Color.Black;
                    buyButton.Enabled = true;
                }
            }
        }
    }
}
