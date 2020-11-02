using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        //create new instance of coin class
        Coin coin = new Coin();
        //create new list of strings called coinResults
        List<string> coinResults = new List<string>();
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// use code from teh coin class to flip coin once
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlip_Clicked(object sender, EventArgs e)
        {
            //flipcoin in the coin class to flip the coin
            coin.FlipCoin();
            //alert that shows the result found in the getsideup method in coin class
            DisplayAlert("Coin Results", coin.GetSideUp(), "Close");
        }
        /// <summary>
        /// flip coin 5x with code from coin class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlip5x_Clicked(object sender, EventArgs e)
        {
            //create new list of strings
            LstViewCoin.ItemsSource = new List<string>();
            //if we've already clicked this we want to clear the previous list
            coinResults.Clear();
            //loop through 5 times 
            for (int i = 0; i < 5; i++)
            {
                //flip coin on each iteration with coin method FlipCoin
                coin.FlipCoin();
                //add result from getsideup to the coinResults list found on top of this page.
                coinResults.Add(coin.GetSideUp());
            }
            //change the list to the results of looping through 5 times and getting 5 results added to the list.
            LstViewCoin.ItemsSource = coinResults;
        }
    }
}
