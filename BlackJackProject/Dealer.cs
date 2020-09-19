using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject
{
    
    public class CardValueGenerator
    {
        Players card = new Players();

        public int Deal()
        {
            int sumValue = card.CardValue;
            int sumValue2 = card.CardValue;
            //int sum = RandomCardNumber() + RandomCardNumber();
            int sum = sumValue + sumValue2;
            return sum;
        }
         public int Hit(int playerHand)
        {
            int sum = playerHand + RandomCardNumber();
            return sum;
        }
        public int RandomCardNumber()
        {
            Random r = new Random();
            int genRandom = r.Next(1, 11);
            return genRandom;
        }
    }
}
