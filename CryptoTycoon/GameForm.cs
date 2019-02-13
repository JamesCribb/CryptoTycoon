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
    public partial class GameForm : Form
    {
        private GameController gc;

        public GameForm()
        {
            gc = new GameController();  // Initialise game logic
            gc.RunDay();    // set prices and rumours

            InitializeComponent();

            DisplayGameInfo();

        }

        private void DisplayGameInfo()
        {
            dayLabel.Text = $"Day: {gc.Day}";
            fundsLabel.Text = $"Funds: {gc.Player.Funds:C}";
            locationLabel.Text = $"Location: {gc.Player.CurrentLocation.Name}";
            healthLabel.Text = $"Health: {gc.Player.CurrentHealth}/{gc.Player.Health}";
            rankLabel.Text = $"Rank: {gc.Player.Rank.Name}";
            inventoryLabel.Text = $"Inventory: {gc.Player.GetNumCoinsInInventory()} / " +
                $"{gc.Player.MaxInventorySize}";

            // Clear the listview ...
            coinsListView.Items.Clear();

            // Get the relevant drug icons
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);
            gc.Player.CurrentLocation.Coins.ForEach(d => imageList.Images.Add(d.Icon));

            // Add the drug information to the listview
            foreach (CoinListItem dli in gc.GetCoinInfo())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dli.ToString();
                item.Tag = dli;
                coinsListView.Items.Add(item);
            }

            // Link the imageList to the ListView
            coinsListView.SmallImageList = imageList;
            // Associate the icons with the listview
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                coinsListView.Items[i].ImageIndex = i;
            }

            // Display the messages
            messagesRichTextBox.Clear();
            List<Message> messages = gc.GetMessages();
            foreach (Message m in messages)
            {
                messagesRichTextBox.SelectionColor = m.MessageColor;
                messagesRichTextBox.AppendText($"{m.Text}\r\n");
            }
            messagesRichTextBox.ScrollToCaret();

            // Display the city 'panorama'
            locationPictureBox.Image = gc.Player.CurrentLocation.Image;
        }

        private void newDayButton_Click(object sender, EventArgs e)
        {
            RunDay();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (coinsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a drug before buying");
            }
            else
            {
                // Dependency issues have been resolved via creation of a DrugListItem class
                CoinListItem coinListItem = (CoinListItem)coinsListView.SelectedItems[0].Tag;
                int coinId = coinListItem.Coin.Id;
                int maxNum = gc.GetMaxCoinsToBuy(coinId);
                string coinName = gc.Player.CurrentLocation.Coins[coinId].Name;
                using (var bsf = new BuySellForm(coinName, "buy", maxNum, gc.GetAverageProfit(coinId)))
                {
                    var result = bsf.ShowDialog();
                    if (result == DialogResult.OK && bsf.Input > 0)
                    {
                        gc.BuyCoins(coinId, bsf.Input);
                        DisplayGameInfo();
                    }
                }
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (coinsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a coin before selling");
            }
            else
            {
                CoinListItem coinListItem = (CoinListItem)coinsListView.SelectedItems[0].Tag;
                int coinId = coinListItem.Coin.Id;
                InventoryCoin iCoin = gc.Player.FindInventoryCoinById(coinId);
                Coin d = iCoin.Coin;
                if (iCoin.Count == 0)
                {
                    MessageBox.Show($"You have no {d.Name} to sell.");
                }
                else
                {
                    int maxNum = gc.GetMaxCoinsToSell(d.Id);
                    string coinName = gc.Player.CurrentLocation.Coins[coinId].Name;
                    using (var bsf = new BuySellForm(coinName, "sell", maxNum,
                        gc.GetAverageProfit(coinId)))
                    {
                        var result = bsf.ShowDialog();
                        if (result == DialogResult.OK && bsf.Input > 0)
                        {
                            gc.SellCoins(coinId, bsf.Input);
                            DisplayGameInfo();
                        }
                    }
                }
            }
        }

        private void travelButton_Click(object sender, EventArgs e)
        {
            using (TravelForm tf = new TravelForm(gc.Locations))
            {
                DialogResult result = tf.ShowDialog();
                if (result == DialogResult.OK && tf.Destination.Id != gc.Player.CurrentLocation.Id)
                {
                    gc.Travel(tf.Destination);
                    RunDay();
                }
            }
        }

        private void hospitalButton_Click(object sender, EventArgs e)
        {
            using (HospitalForm hf = new HospitalForm(gc))
            {
                DialogResult result = hf.ShowDialog();
                if (result == DialogResult.OK)
                {
                    gc.RecoverHealthHospital(hf.HealthToRecover);
                    DisplayGameInfo();
                }
            }
        }

        // Instructs the game controller to begin a new day
        private void RunDay()
        {
            if (gc.RunDay())
            {
                MessageBox.Show("The game is over and will now close.");
                Application.Exit();
            }
            else
            {
                if (gc.IsFightHappening)
                {
                    DialogResult result;
                    using (FightForm ff = new FightForm(gc))
                    {
                        result = ff.ShowDialog();
                    }
                    if (result == DialogResult.Abort)
                    {
                        MessageBox.Show("You have been defeated. The game will now close.");
                        Application.Exit();
                    }
                }
                DisplayGameInfo();
            }
        }

        private void blackMarketButton_Click(object sender, EventArgs e)
        {
            using (BlackMarketForm bmf = new BlackMarketForm(gc))
            {
                DialogResult result = bmf.ShowDialog();
                DisplayGameInfo();
            }
        }
    }
}
