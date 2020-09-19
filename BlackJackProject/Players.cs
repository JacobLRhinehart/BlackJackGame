using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject
{
   public class Players
    {
        public int DealerScore { get; set; }
        public int PlayerScore { get; set; }

        public int CardValue
        {
            get
            {
                Random r = new Random();
                int genRandom = r.Next(1, 11);
                return genRandom;
            }
        }
    }
}
