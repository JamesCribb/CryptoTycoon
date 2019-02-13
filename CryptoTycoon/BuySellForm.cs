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
    public partial class BuySellForm : Form
    {
        public int Input { get; set; }

        public BuySellForm(string coinName, string command, int maxNum, int averageProfit)
        {
            InitializeComponent();
            string capitalisedCommand = command.First().ToString().ToUpper() + command.Substring(1);
            Text = capitalisedCommand + " Coins";
            buySellLabel.Text = $"How many units of {coinName} would you like to {command}? (Max: {maxNum})";
            buySellNumericUpDown.Maximum = maxNum;

            maxButton.Text = $"{capitalisedCommand} Max";
            halfButton.Text = $"{capitalisedCommand} 50%";

            // TODO: Implement a separate sell form, or refactor?
            if (command.Equals("buy"))
            {
                profitLabel.Hide();
            }
            else
            {
                profitLabel.Text = $"Profit per unit sold: ${averageProfit}";
            }
        }

        private void buySellNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Input = (int)buySellNumericUpDown.Value;
        }

        private void buySellOkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            buySellNumericUpDown.Value = buySellNumericUpDown.Maximum;
            Input = (int)buySellNumericUpDown.Maximum;
        }

        private void halfButton_Click(object sender, EventArgs e)
        {
            buySellNumericUpDown.Value = buySellNumericUpDown.Maximum / 2;
            Input = (int)buySellNumericUpDown.Maximum / 2;
        }
    }
}
