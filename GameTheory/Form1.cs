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

            Zoran igrac1 = new Zoran();
            Zoran igrac2 = new Zoran();

            int poeni1 = 0;
            int poeni2 = 0;

            for (int i = 0; i < brojIteracija; i++) 
            {
                dataGridView1.Rows.Add();

                Potez poslednji1 = igrac1.Play();
                Potez poslednji2 = igrac2.Play();

                dataGridView1[0, i].Style.BackColor = poslednji1 == Potez.Zeleno ? Color.Green : Color.Red;
                dataGridView1[1, i].Style.BackColor = poslednji2 == Potez.Zeleno ? Color.Green : Color.Red;

                if (poslednji1 == Potez.Zeleno && poslednji2 == Potez.Zeleno)
                {
                    poeni1 += 3;
                    poeni2 += 3;
                    continue;
                }

                if (poslednji1 == Potez.Crveno && poslednji2 == Potez.Zeleno)
                {
                    poeni1 += 5;
                    poeni2 += 0;
                    continue;
                }

                if (poslednji1 == Potez.Zeleno && poslednji2 == Potez.Crveno)
                {
                    poeni1 += 0;
                    poeni2 += 5;
                    continue;
                }

                poeni1 += 1;
                poeni2 += 1;
            }
        }
    }
    public enum Potez
    {
        Crveno,
        Zeleno
    }
}
