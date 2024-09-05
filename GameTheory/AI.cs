using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTheory
{
    internal interface AI
    {
        void GetLastPlay(Potez p);

        Potez Play();

    }
}
