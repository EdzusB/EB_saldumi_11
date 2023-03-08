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
        double atlaide = 1;
        double gala_atlaide = 0;
        double summa = 0;
        double gala_cena = 0;
        double rez0 = 0;
        double rez1 = 0;
        double rez2 = 0;
        double rez3 = 0;
        double rez4 = 0;
        double rez5 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aprekins_Click(object sender, EventArgs e)
        {
            if (text0.Text == "")
            {
                kg0 = 0;
                izmaksas1.Text = 0.ToString();
            }           
            else
            {
                kg0 = Convert.ToDouble(text0.Text);
                if(kg0<0)
                {
                MessageBox.Show("Jūs mums pārdosiet konfektes?");
               }              
            }
            
            rez0 = Izmaksas0(kg0, sk2);
            izmaksas1.Text = rez0.ToString();

            if (text1.Text == "" )
            {
                kg1 = 0;
                izmaksas2.Text = 0.ToString();
            }
            else
            {
                kg1 = Convert.ToDouble(text1.Text);
                if (kg1 < 0)
                {
                    MessageBox.Show("Jūs mums pārdosiet konfektes?");
                }
            }
            rez1 = Izmaksas1(kg1, sk3);
            izmaksas2.Text = rez1.ToString();

            if (text2.Text == "")
            {
                kg2 = 0;
                izmaksas3.Text = 0.ToString();
            }
            else
            {
                kg2 = Convert.ToDouble(text2.Text);
                if (kg2 < 0)
                {
                    MessageBox.Show("Jūs mums pārdosiet konfektes?");
                }

            }
            rez2 = Izmaksas2(kg2, sk4);
            izmaksas3.Text = rez2.ToString();
            

            if (text3.Text == "")
            {
                kg3 = 0;
                izmaksas4.Text = 0.ToString();
            }
            else
            {
                kg3 = Convert.ToDouble(text3.Text);
                if (kg3 < 0)
                {
                    MessageBox.Show("Jūs mums pārdosiet konfektes?");
                }

            }
            rez3 = Izmaksas3(kg3, sk5);
            izmaksas4.Text = rez3.ToString();
            

            if (text4.Text == "")
            {
                kg4 = 0;
                izmaksas5.Text = 0.ToString();
            }
            else
            {
                kg4 = Convert.ToDouble(text4.Text);
                if (kg4 < 0)
                {
                    MessageBox.Show("Jūs mums pārdosiet konfektes?");
                }

            }
            rez4 = Izmaksas4(kg4, sk6);
            izmaksas5.Text = rez4.ToString();
            

            if (text6.Text == "")
            {
                kg5 = 0;
                izmaksas6.Text = 0.ToString();
            }
            else
            {
                kg5 = Convert.ToDouble(text6.Text);
                if (kg5 < 0)
                {
                    MessageBox.Show("Jūs mums pārdosiet konfektes?");
                }

            }
            rez5 = Izmaksas5(kg5, sk7);
            izmaksas6.Text = rez5.ToString();
            

            if (checkatlaide.Checked == true)
            {
                atlaide = 0.13;
                gala_atlaide = summa * atlaide;
                atlaidesbox.Text = gala_atlaide.ToString();
            }

            if(daudzums.Text == "")
            {
                MessageBox.Show("Lūdzu aizpildiet pieejamā naudas daudzuma lauku!");
            }
            else
            {
                 sk1 = Convert.ToDouble(daudzums.Text);
            }
            
            summa = rez0 + rez1 + rez2 + rez3 + rez4 + rez5;
            gala_cena = summa - gala_atlaide;

            gala_summa.Text = gala_cena.ToString();
            atlikums = sk1 - gala_cena;
            daudzums_kg.Text = atlikums.ToString();

            if (atlikums < 0)
            {
                MessageBox.Show("Jums nav pietiekami daudz naudas!!!");
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void check0_CheckedChanged(object sender, EventArgs e)
                {
                    if(check0.Checked == true)
                    {
                        sk2 = 4.89;
                    }
            
                }
        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if(check1.Checked == true)
                        {
                            sk3 = 17.63;
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
            }
        }

        private void check3_CheckedChanged(object sender, EventArgs e)
        {
            if(check3.Checked == true)
            {
                sk5 = 12.19;
            }
        }

        private void check4_CheckedChanged(object sender, EventArgs e)
        {
            
            if (check4.Checked == true)
            {
                sk6 = 10.69;
            }
        }

               private void check5_CheckedChanged(object sender, EventArgs e)
        {
            if (check5.Checked == true)
            {
                sk7 = 14.99;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string vards;

            if(string.IsNullOrEmpty(vardaBox.Text))
            {
                MessageBox.Show("Lūdzu norādiet savu vārdu!");
            }

             vards = this.vardaBox.Text;
            ierakstisana_faila( vards, rez0, rez1, rez2, rez3, rez4, rez5, kg0, kg1, kg2, kg3, kg4, kg5, sk1, sk2, sk3, sk4, sk5, sk6, sk7, summa, gala_atlaide, gala_cena, atlikums);


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
        static double Izmaksas0(double kg0, double sk2)
        {
            double nauda0 = kg0* sk2;
            return nauda0;
        }
                
        static double Izmaksas1(double kg1, double sk3 )
        {
            double nauda1 = kg1 * sk3;
            return nauda1;
        }

        static double Izmaksas2(double kg2, double sk4)
        {
            double nauda2 = kg2 * sk4;
            return nauda2;
        }

        static double Izmaksas3(double kg3, double sk5)
        {
            double nauda3 = kg3 * sk5;
            return nauda3;
        }

        static double Izmaksas4(double kg4, double sk6)
        {
            double nauda4 = kg4 * sk6;
            return nauda4;
        }

        static double Izmaksas5(double kg5, double sk7)
        {
            double nauda5 = kg5 * sk7;
            return nauda5;
        }

        public static void ierakstisana_faila(string vards, double rez0, double rez1, double rez2, double rez3, double rez4, double rez5, double kg0,double kg1, double kg2, double kg3, double kg4, double kg5, double sk1, double sk2, double sk3, double sk4, double sk5, double sk6, double sk7, double summa, double gala_atlaide, double gala_cena, double atlikums)      
        {
            string failanosaukums = vards + "_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + "_ceks.txt";                     
                         
            StreamWriter sw = new StreamWriter(failanosaukums);          

            sw.WriteLine("SIA <<RIMI>>");
            sw.WriteLine(" ");
           
            if (rez0 != 0)
            {
                sw.WriteLine("Marmelāde");
                sw.WriteLine(kg0 + "kg x " + sk2 + "Eur = " + rez0 + "Eur");
            }
            
            if (rez1 != 0)
            {
                sw.WriteLine("Konfektes serenāde");
                sw.WriteLine(kg1 + "kg x " + sk3 + "Eur = " + rez1 + "Eur");
            }

            if (rez2 != 0)
            {
                sw.WriteLine("Konfektes Migle");
                sw.WriteLine(kg2 + "kg x " + sk4 + "Eur = " + rez2 + "Eur");
            }

            if (rez3 != 0)
            {
                sw.WriteLine("Konfektes Rudzupuķe");
                sw.WriteLine(kg3 + "kg x " + sk5 + "Eur = " + rez3 + "Eur");
            }

            if (rez4 != 0)
            {
                 sw.WriteLine("Konfektes Gotiņa");
                sw.WriteLine(kg4 + "kg x " + sk6 + "Eur = " + rez4 + "Eur");
            }

            if (rez5 != 0)
            {
                sw.WriteLine("Konfektes Vētrasputns");
                sw.WriteLine(kg5 + "kg x " + sk7 + "Eur = " + rez5 + "Eur");
            }

            sw.WriteLine(" ");
            sw.WriteLine("Samaksai Eur " + summa);

            if(gala_atlaide != 0)
            {
            sw.WriteLine("Iegūtā atlaide Eur " + gala_atlaide);
            }
            
            sw.WriteLine("Samaksai pēc atlaides Eur " + gala_cena);
            sw.WriteLine("Saņemtā nauda Eur " + sk1);
            sw.WriteLine("Izdotā nauda Eur " + atlikums);
            sw.Close();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
