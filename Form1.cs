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
           banka = new Banka("Pavel Kratochvíl", 50000, 40000);
        }

        private void button_vklad_Click(object sender, EventArgs e)
        {
            int castka = int.Parse(textbox_castka.Text);
            banka.Vklad(castka);           
            
        }

        private void button_vyber_Click(object sender, EventArgs e)
        {

        }

        private void button_platba_Click(object sender, EventArgs e)
        {

        }
    }
}
