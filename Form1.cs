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
            textbox_castka.Enabled = false;
            button_platba.Enabled = false;
            button_vyber.Enabled = false;
            button_vklad.Enabled = false;
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
            label_stav.Text = "Aktuální stav účtu je " + banka.Stav.ToString();

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
            label_stav.Text = "Aktuální stav účtu je " + banka.Stav.ToString();

            }
            catch
            {
                MessageBox.Show("Nezadal jsi částku!");
            }
           

        }

        private void label_stav_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string jmeno = textbox_jmeno.Text;
            int limit_vklad = int.Parse(textbox_limit_vklad.Text);
            int limit_platba = int.Parse(textbox_limit_platba.Text);
            banka = new Banka(jmeno, limit_vklad, limit_platba);
            textbox_jmeno.Enabled = false;
            textbox_limit_platba.Enabled = false;
            textbox_limit_vklad.Enabled = false;
   
            textbox_castka.Enabled = true;
            button_platba.Enabled = true;
            button_vyber.Enabled = true;
            button_vklad.Enabled = true;
            label_jmeno.Text = banka.Jmeno;
            label_limit_platba.Text = "Limit pro platbu je " + banka.LimitPlatba.ToString();
            label_limit_vklad.Text = "Limit pro vklad je " + banka.LimitVklad.ToString();
            }
            catch
            {
                MessageBox.Show("Nezadal jsi údaje k účtu"!);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textbox_jmeno.Enabled = true;
            textbox_limit_platba.Enabled = true;
            textbox_limit_vklad.Enabled = true;
            textbox_jmeno.Text = "";
            textbox_limit_platba.Text = "";
            textbox_limit_vklad.Text = "";
            textbox_castka.Text = "";
        }
    }
}
