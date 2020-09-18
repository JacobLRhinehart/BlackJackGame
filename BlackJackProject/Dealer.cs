using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject
{
    public class CardValueGenerator
    {
        public int Deal()
        {
            int sum = RandomCardNumber() + RandomCardNumber();
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
