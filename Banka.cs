using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Test_20211109
{
    public class Banka
    {
        public string Jmeno;
        public float LimitVklad;
        public float LimitPlatba;
        public float Stav = 0;

        public Banka(string jmeno, int limit_vklad, int limit_platba)
        {
            this.Jmeno = jmeno;
            this.LimitVklad = limit_vklad;
            this.LimitPlatba = limit_platba;
        }

        public void Vklad(int castka)
        {
            if (castka > LimitVklad)
            {
                MessageBox.Show("Tato částka přesahuje možnost maximálního vkladu");
            }
            else if (castka < LimitVklad)
            {
                Stav += castka;
                MessageBox.Show($"Byla připsána částka {Stav}");
            }
        }
        public void Vyber(int castka)
        {
        }
        public void Platba(int castka)
        {

        }
       

    }
   
}
