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
    public partial class FightForm : Form
    {
        GameController gc;
        Player player;
        Enemy enemy;

        public FightForm(GameController gc)
        {
            InitializeComponent();
            this.gc = gc;
            enemy = gc.Enemy;
            player = gc.Player;
            enemyPictureBox.Image = enemy.Image;
            enemyHealthLabel.Text = $"{enemy.CapitalisedName}:";

            gc.Player.AvailableWeapons.ForEach(w => weaponListBox.Items.Add(w));
            weaponListBox.SetSelected(player.AvailableWeapons.IndexOf(player.Weapon), true);

            DisplayFightInfo();
        }

        private void DisplayFightInfo()
        {
            //enemyHealthLabel.Text = $"Enemy Health: {enemy.CurrentHealth}/{enemy.Health}";
            //playerHealthLabel.Text = $"Player Health: {player.CurrentHealth}/{player.Health}";
            fightMessageRichTextBox.Clear();
            foreach (Message fm in gc.GetFightMessages())
            {
                fightMessageRichTextBox.SelectionColor = fm.MessageColor;
                fightMessageRichTextBox.AppendText($"{fm.Text}\r\n");
            }
            fightMessageRichTextBox.ScrollToCaret();
            // Update the health bars
            playerHealthPanel.Refresh();
            enemyHealthPanel.Refresh();
            // Re-enable the flee button
            fleeButton.Enabled = true;
        }

        // The player can try to flee once per turn.
        // Fleeing does not count as an action: if it fails, the player still has to fight
        private void fleeButton_Click(object sender, EventArgs e)
        {
            if (gc.TryToFlee())
            {
                gc.GetMessages().Add(new Message($"You manage to flee from the {enemy.Name}", Color.DarkCyan));
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You try to flee ... but can't get away this turn!");
                fleeButton.Enabled = false;
            }
        }

        private void fightButton_Click(object sender, EventArgs e)
        {
            int result = gc.FightTurn();
            DisplayFightInfo();
            // TODO: Pass enumeration instead
            if (result == 0)
            {
                MessageBox.Show($"You have been defeated by a {enemy.Name}.");
                DialogResult = DialogResult.Abort;
                Close();
            }
            else if (result == 1)
            {
                MessageBox.Show($"You have defeated the {enemy.Name}.");
                // TODO: Write your own, relevant dialogs !
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void DrawHealthBar(Graphics g, int panelWidth, int panelHeight, Character c)
        {
            Pen pen = new Pen(Color.Black, 1);
            Rectangle border = new Rectangle(0, 0, panelWidth - 1, panelHeight - 10);
            g.DrawRectangle(pen, border);

            // Determine how much of the health bar to fill
            float healthPercentage = c.CurrentHealth / (float)c.Health;
            float panelPercentage = panelWidth * healthPercentage;
            int width = (int)panelPercentage;

            Rectangle inner = new Rectangle(1, 1, width - 2, panelHeight - 11);
            g.FillRectangle(new SolidBrush(Color.Red), inner);
        }

        private void playerHealthPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawHealthBar(e.Graphics, playerHealthPanel.Width, playerHealthPanel.Height, gc.Player);
        }

        private void enemyHealthPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawHealthBar(e.Graphics, enemyHealthPanel.Width, enemyHealthPanel.Height, gc.Enemy);
        }

        private void weaponListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.Weapon = (Weapon)weaponListBox.SelectedItem;
        }
    }
}
