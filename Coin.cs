using System;
using System.Collections.Generic;
using System.Text;

namespace CoinFlip
{
    //create class called Coin
    public class Coin
    {
        //instantiate Random so we can use it's methods
        Random rand;
        //delcare _sideup variable for our results
        private string _sideup;
        //create constructor method for Coin class
        public Coin()
        {
            //instantiate random  when constructor is called
            rand = new Random();
            //set a default value to _sideup
            _sideup = "Heads";
        }
        /// <summary>
        /// Flips the coin using methods from the Random Class
        /// </summary>
        public void FlipCoin()
        {
            //get random whole number between 0 and 1
            int randomSide = rand.Next(2);
            //check what the number is
            if (randomSide == 0)
            {
                //if 0 assign _sideup to Heads
                _sideup = "Heads";
            }
            else
            {
                //if 1 assign _sideup to Tails

                _sideup = "Tails";

            }
        }
        /// <summary>
        /// gives us the assigned value to _sideup
        /// </summary>
        /// <returns></returns>
        public string GetSideUp()
        {
            //returns _sideup as a string
            return _sideup;
        }
    }
}
