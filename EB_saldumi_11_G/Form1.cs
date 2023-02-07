using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EB_saldumi_11_G
{
    public partial class Form1 : Form
    {
        double sk1 = 0;
        double sk2 = 0;
        double sk3 = 0;
        double sk4 = 0;
        double sk5 = 0;
        double sk6 = 0;
        double cena = 0;
        double skaits = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aprekins_Click(object sender, EventArgs e)
        {
            sk1 = Convert.ToDouble(daudzums.Text);
            cena = (sk2 + sk3 + sk4 + sk5 + sk6) / skaits;
             daudzums_kg.Text = (sk1 / cena).ToString();
            ///daudzums_kg.Text = daudzums_kg.ToString(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            if(check1.Checked == true)
            {
                sk3 = 17.63;
                skaits = skaits + 1;
            }
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            if(check2.Checked == true)
            {
                sk4 = 7.49;
                skaits = skaits + 1;
            }
        }

        private void check3_CheckedChanged(object sender, EventArgs e)
        {
            if(check3.Checked == true)
            {
                sk5 = 12.19;
                skaits = skaits + 1;
            }
        }

        private void check4_CheckedChanged(object sender, EventArgs e)
        {
            if (check4.Checked == true)
            {
                sk6 = 10.69;
                skaits = skaits + 1;
            }
        }

        private void check0_CheckedChanged(object sender, EventArgs e)
        {
            if(check0.Checked == true)
            {
                sk2 = 9.88;
                skaits = skaits + 1;
            }
        }

        private void daudzums_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
