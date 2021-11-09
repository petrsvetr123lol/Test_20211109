using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public partial class Form1 : Form
    {
        Banka banka;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           banka = new Banka("Pavel Kratochvíl", 200000, 15000);
           label_jmeno.Text = banka.Jmeno;
            label_limit_platba.Text = "Limit pro platbu je " + banka.LimitPlatba.ToString();
            label_limit_vklad.Text = "Limit pro vklad je " + banka.LimitVklad.ToString();

        }

        private void button_vklad_Click(object sender, EventArgs e)
        {
            try
            {
            int castka = int.Parse(textbox_castka.Text);
            banka.Vklad(castka);
            label_stav.Text = "Aktuální stav účtu je " + banka.Stav.ToString();

            }
            catch
            {
                MessageBox.Show("Nezadal jsi částku!");
            }
                  
            
        }
        
        private void button_vyber_Click(object sender, EventArgs e)
        {
            try
            {
            int castka = int.Parse(textbox_castka.Text);
            banka.Vyber(castka);
            }
            catch
            {
                MessageBox.Show("Nezadal jsi částku!");
            }
           

        }

        private void button_platba_Click(object sender, EventArgs e)
        {
            try
            {
            int castka = int.Parse(textbox_castka.Text);
            banka.Platba(castka);
            }
            catch
            {
                MessageBox.Show("Nezadal jsi částku!");
            }
           

        }

        private void label_stav_Click(object sender, EventArgs e)
        {

        }
    }
}
