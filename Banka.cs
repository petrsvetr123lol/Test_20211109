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
                MessageBox.Show($"Byla připsána částka {castka} a máš {Stav}");
            }
        }
        public void Vyber(int castka)
        {
            if (castka > Stav)
            {
                MessageBox.Show($"Tolik peněž nemůžeš dostat, protože tolik peněž nemáš. Aktuálně máš {Stav}");
            }
            else if (castka < Stav && castka != 0)
            {
                Stav -= castka;
                MessageBox.Show($"Vybral jsi {castka} peněz a zbylo ti {Stav}");
            }
        }
        public void Platba(int castka)
        {
            if (castka >= LimitPlatba && castka == 0)
            {
                MessageBox.Show($"Tvoje platba převyšuje maximální limit {LimitPlatba}, nezaplatím nic.");
            }
            else if (castka <= LimitPlatba && castka <= Stav)
            {
                Stav -= castka;
                MessageBox.Show($"Platba v hodnotě {castka} byla zaplacena. Na účtě zůstalo {Stav}");
            }
        }
       

    }
   
}
