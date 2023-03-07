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
        double atlaide = 1;
        double gala_atlaide = 0;
        double summa = 0;
        double gala_cena = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aprekins_Click(object sender, EventArgs e)
        {

            if (checkatlaide.Checked == true)
            {
                atlaide = 0.13;
                gala_atlaide = summa * atlaide;
                atlaidesbox.Text = gala_atlaide.ToString();
            }

            sk1 = Convert.ToDouble(daudzums.Text);
            summa = nauda0 + nauda1 + nauda2 + nauda3 + nauda4 + nauda5;
            gala_cena = summa - gala_atlaide;

            gala_summa.Text = gala_cena.ToString();
            atlikums = sk1 - gala_cena;
            daudzums_kg.Text = atlikums.ToString();
            Izmaksas1 = kg0 * sk2;
            Izmaksas2 = sk3 * kg1;
            Izmaksas3 = sk4 * kg2;
            Izmaksas4 = sk5 * kg3;
            Izmaksas5 = sk6 * kg4;
            Izmaksas6 = sk7 * kg5;


            izmaksas1.Text = Izmaksas1.ToString();
            izmaksas2.Text = Izmaksas2.ToString();
            izmaksas3.Text = Izmaksas3.ToString();
            izmaksas4.Text = Izmaksas4.ToString();
            izmaksas5.Text = Izmaksas5.ToString();
            izmaksas6.Text = Izmaksas6.ToString();

            if (atlikums < 0)
            {
                MessageBox.Show("Jums nav pietiekami daudz naudas!!!");
                Application.Exit();
            }
        
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
                kg5 = Convert.ToDouble(text6.Text);
                nauda5 = kg5 * sk7;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ceka_Nr = 0;
            string vards = this.vardaBox.Text;
            string failanosaukums = vards + ceka_Nr + "_" + DateTime.Now.ToString("ddMMyyyy") + "_ceks.txt";

            if (File.Exists(failanosaukums))
            {
                ceka_Nr = ceka_Nr + 1;
                failanosaukums = vards + ceka_Nr + "_" + DateTime.Now.ToString("ddMMyyyy") + "_ceks.txt";
            }


            StreamWriter sw = new StreamWriter(failanosaukums);

            sw.WriteLine("SIA <<RIMI>>");
            sw.WriteLine(" ");
           
            if (text0.Text.Equals(" "))
            {
                MessageBox.Show("Aizpildiet šo lauku!");
            }
            else
            {
                sw.WriteLine("Marmelāde");
                sw.WriteLine(kg0 + "kg x " + sk2 + "Eur = " + nauda0 + "Eur");
            }

            if (text1.Text.Equals(" "))
            {
                MessageBox.Show("Aizpildiet šo lauku!");
            }
            else
            {
                sw.WriteLine("Konfektes serenāde");
                sw.WriteLine(kg1 + "kg x " + sk3 + "Eur = " + nauda1 + "Eur");
            }

            if (text2.Text.Equals(" "))
            {
                MessageBox.Show("Aizpildiet šo lauku!");
            }
            else
            {
                sw.WriteLine("Konfektes Migle");
                sw.WriteLine(kg2 + "kg x " + sk4 + "Eur = " + nauda2 + "Eur");
            }

            if (text3.Text.Equals(" "))
            {
                MessageBox.Show("Aizpildiet šo lauku!");
            }
            else
            {
                sw.WriteLine("Konfektes Rudzupuķe");
                sw.WriteLine(kg3 + "kg x " + sk5 + "Eur = " + nauda3 + "Eur");
            }

            if (text4.Text.Equals(" "))
            {
                MessageBox.Show("Aizpildiet šo lauku!");
            }
            else
            {
                sw.WriteLine("Konfektes Gotiņa");
                sw.WriteLine(kg4 + "kg x " + sk6 + "Eur = " + nauda4 + "Eur");
            }

            if (text6.Text.Equals(" "))
            {
                MessageBox.Show("Aizpildiet šo lauku!");
            }
            else
            {
                sw.WriteLine("Konfektes Vētrasputns");
                sw.WriteLine(kg5 + "kg x " + sk7 + "Eur = " + nauda5 + "Eur");
            }

            sw.WriteLine(" ");
            sw.WriteLine("Samaksai Eur " + summa);
            sw.WriteLine("Iegūtā atlaide Eur " + gala_atlaide);
            sw.WriteLine("Samaksai pēc atlaides Eur " + gala_cena);
            sw.WriteLine("Saņemtā nauda Eur " + sk1);
            sw.WriteLine("Izdotā nauda Eur " + atlikums);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkatlaide.Checked == true)
            {
                atlaide = 0.13;
                gala_atlaide = sk1 * atlaide;
            }
        }
    }
}
