using System;

// This class groups information to be displayed as a single item in the ListBox/View
namespace CryptoTycoon
{
    public class CoinListItem
    {
        public Coin Coin { get; set; }
        public int AveragePrice { get; set; }
        public int NumInInventory { get; set; }
        private bool isFirstDay;

        public CoinListItem(Coin coin, int averagePrice, int numInInventory, int day)
        {
            Coin = coin;
            AveragePrice = averagePrice;
            NumInInventory = numInInventory;
            isFirstDay = day == 1 ? true : false;
        }

        public string[] ToStringArray()
        {
            string priceChange = "";
            if (!isFirstDay)
            {
                int change = Coin.Price - Coin.PastPrices[Coin.PastPrices.Count - 1];
                priceChange = change > 0 ? $"+{change}" : $"{change}";
            }

            string[] array = new string[5];
            array[0] = Coin.Name;
            array[1] = Coin.Price.ToString();
            array[2] = priceChange;
            array[3] = AveragePrice.ToString();
            array[4] = NumInInventory.ToString();

            return array;
        }

        public override string ToString()
        {
            string priceChange = "";
            if (!isFirstDay)
            {
                int change = Coin.Price - Coin.PastPrices[Coin.PastPrices.Count - 1];
                if (change < 0)
                {
                    priceChange = $"- ${Math.Abs(change)}";
                }
                else if (change == 0)
                {
                    priceChange = $"  ${change}";
                }
                else
                {
                    priceChange = $"+ ${change}";
                }


                //priceChange = change > 0 ? $"+ ${change}" : $"- ${Math.Abs(change)}";
            }

            int length = -20 + Coin.Name.Length;

            string firstAttempt = $"{Coin.Name}\t\t{Coin.Price}\t\t" +
                $"{priceChange}\t\t{AveragePrice}" +
                $"\t\t{NumInInventory}";

            string secondAttempt = $"  {Coin.Name,-13}${Coin.Price,-13}" +
                $"{priceChange,-15}${AveragePrice,-16}" +
                $"{NumInInventory,-17}";

            return secondAttempt;
        }
    }
}
