using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        double sk7 = 0;
        double cena = 0;
        double skaits = 0;
        double kg0 = 0;
        double kg1 = 0;
        double kg2 = 0;
        double kg3 = 0;
        double kg4 = 0;
        double kg5 = 0;
        double nauda0 = 0;
        double nauda1 = 0;
        double nauda2 = 0;
        double nauda3 = 0;
        double nauda4 = 0;
        double nauda5 = 0;
        double atlikums = 0;
        double Izmaksas1 = 0;
        double Izmaksas2 = 0;
        double Izmaksas3 = 0;
        double Izmaksas4 = 0;
        double Izmaksas5 = 0;
        double Izmaksas6 = 0;


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
            atlikums = sk1-(nauda0 + nauda1 + nauda2 + nauda3 + nauda4);
             daudzums_kg.Text = atlikums.ToString();
            //daudzums_kg.Text = daudzums_kg.ToString(); 
            Izmaksas1 = kg0 * sk2;
            Izmaksas1 = Convert.ToDouble(izmaksas1.Text);
            izmaksas1.Text = Izmaksas1.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if(check1.Checked == true)
                        {
                            sk3 = 17.63;
                            skaits = skaits + 1;
                            kg1 = Convert.ToDouble(text1.Text);
                            nauda1 = kg1 * sk3;
                        }
            }
            catch
            {
                MessageBox.Show("Nekorekti ievadits daudzums!");
            }
            
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            if(check2.Checked == true)
            {
                sk4 = 7.49;
                skaits = skaits + 1;
                kg2 = Convert.ToDouble(text2.Text);
                nauda2 = kg2 * sk4;
            }
        }

        private void check3_CheckedChanged(object sender, EventArgs e)
        {
            if(check3.Checked == true)
            {
                sk5 = 12.19;
                skaits = skaits + 1;
                kg3 = Convert.ToDouble(text3.Text);
                nauda3 = kg3 * sk5;
            }
        }

        private void check4_CheckedChanged(object sender, EventArgs e)
        {
            
            if (check4.Checked == true)
            {
                sk6 = 10.69;
                skaits = skaits + 1;
                kg4 = Convert.ToDouble(text4.Text);
                nauda4 = kg4 * sk6;
            }
        }

        private void check0_CheckedChanged(object sender, EventArgs e)
        {
            if(check0.Checked == true)
            {
                sk2 = 4.89;
                skaits = skaits + 1;
                kg0 = Convert.ToDouble(text0.Text);
                nauda0 = kg0 * sk2;
            }
        }

        private void daudzums_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text3_TextChanged(object sender, EventArgs e)
        {

        }

        private void text4_TextChanged(object sender, EventArgs e)
        {

        }

        private void text5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void text6_TextChanged(object sender, EventArgs e)
        {

        }

        private void check5_CheckedChanged(object sender, EventArgs e)
        {
            if (check5.Checked == true)
            {
                sk7 = 14.99;
                skaits = skaits + 1;
                kg5 = Convert.ToDouble(text2.Text);
                nauda2 = kg5 * sk7;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vards = this.vardaBox.Text;
            string failanosaukums = vards + "_" + DateTime.Now.ToString("ddMMyyyy") + "_ceks.txt";
            StreamWriter sw = new StreamWriter(failanosaukums);
            sw.WriteLine(sk1);
            sw.WriteLine(atlikums);

            sw.Close();
        }

        private void daudzums_kg_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vardaBox_TextChanged(object sender, EventArgs e)
        {
            string vards = vardaBox.Text;
        }
        void faila_ierakstisana()
        {
            
        }

        private void izmaksas1_TextChanged(object sender, EventArgs e)
        {
            


        }
    }
}
