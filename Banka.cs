using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Test_20211109
{
    public class Banka
    {
        public string Jmeno;
        public int LimitVklad;
        public int LimitPlatba;
        public int Stav = 0;

        public Banka(string jmeno, int limit_vklad, int limit_platba)
        {
            this.Jmeno = jmeno;
            this.LimitVklad = limit_vklad;
            this.LimitPlatba = limit_platba;
        }

        public void Vklad(int castka)
        {

        }
        public void Vyber()
        {

        }
        public void Platba()
        {

        }
       

    }
   
}
