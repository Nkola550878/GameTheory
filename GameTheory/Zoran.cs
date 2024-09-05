using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTheory
{
    public class Zoran : AI
    {
        Random random = new Random();
        public void GetLastPlay(Potez p)
        {
            return;
        }


        public Potez Play()
        {
            return random.Next(0, 100) % 2 == 0 ? Potez.Zeleno : Potez.Crveno;
        }
    }
}
