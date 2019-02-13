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
    public partial class HospitalForm : Form
    {
        private GameController gc;
        public int HealthToRecover { get; set; }

        public HospitalForm(GameController gc)
        {
            this.gc = gc;
            int maxHealth = gc.Player.Health;
            int currentHealth = gc.Player.CurrentHealth;

            InitializeComponent();
            recoveryNumericUpDown.Maximum = maxHealth - currentHealth;
            recoveryNumericUpDown.Minimum = 0 - currentHealth;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void recoveryNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            HealthToRecover = (int)recoveryNumericUpDown.Value;
            if (HealthToRecover < 0)
            {
                costLabel.Text = "We can't have patients dying on us!";
                okButton.Enabled = false;
            }
            else
            {
                int cost = gc.CalculateHospitalCost(HealthToRecover);
                if (cost > gc.Player.Funds)
                {
                    costLabel.Text = "Cost: More than you can afford!";
                    okButton.Enabled = false;
                }
                else
                {
                    costLabel.Text = $"Cost: ${cost}";
                    okButton.Enabled = true;
                }
            }
        }
    }
}
