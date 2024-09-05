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
            return Tools.Random(0.0, 1.0) < 0.5 ? Potez.Zeleno : Potez.Crveno;
        }
    }
}
