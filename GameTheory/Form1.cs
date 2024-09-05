using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTheory
{
    public partial class Form1 : Form
    {
        int brojIteracija = 100;
        public Form1()
        {
            InitializeComponent();
            

            for (int i = 0; i < brojIteracija; i++) 
            {
                igrac1.Play();
                igrac2.Play();
            }
        }
        

    }
    public enum Potez
    {
        Crveno,
        Zeleno
    }
}
